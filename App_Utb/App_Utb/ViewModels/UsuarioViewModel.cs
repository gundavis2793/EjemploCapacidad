using App_Utb.Data;
using App_Utb.Helpers;
using App_Utb.JsonModels;
using App_Utb.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App_Utb.ViewModels
{
    class UsuarioViewModel : BaseViewModel
    {
        public MateriaDocenteDataBase MateriaDocenteData = new MateriaDocenteDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public MateriaDataBase MateriaData = new MateriaDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public ListaEstudiantesDataBase ListaEstudiantesData = new ListaEstudiantesDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public UsuarioDatabase UsuarioData = new UsuarioDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public CarreraDatabase CarreraData = new CarreraDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public HorarioDataBase HorarioData = new HorarioDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
        public System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        public Verificacion_Usuario Usu { get; set; }
        public string nombre { get; set; }
        public string tipoUsuario { get; set; }
        Carrera_Usuario carUsu { get; set; }
        ListaMateriasDocente listaMateriasDocente { get; set; }
        string ArchivoJson { get; set; }
        public string TemaTipo { get; set; }
        public string TemaCarrera { get; set; }
        public string TemaTurno { get; set; }
        public string TemaUnidad { get; set; }
        public string[] TemaUnidadDocente { get; set; }
        public string[] TemaTurnoDocente { get; set; }
        public string[] TemaCarreraDocente { get; set; }
        public int gestion { get; set; }
        public string periodo { get; set; }
        public async Task CargarUsuario(string usus, string pass)
        {

            UsuarioData.DeleteAll();
            MateriaDocenteData.DeleteAll();
            MateriaData.DeleteAll();
            CarreraData.DeleteAll();
            HorarioData.DeleteAll();
            ListaEstudiantesData.DeleteAll();
            var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_autenticar_usuario.php/?usuario={usus}&pwd={pass}");
            ArchivoJson = response.Content.ReadAsStringAsync().Result;
            Usu = new Verificacion_Usuario();
            var ele = JsonConvert.DeserializeObject<Usuario>(ArchivoJson);
            bool retu = false;
            if (ele.verificacion_usuario[0].validado.Equals("1"))
            {
                nombre = ele.verificacion_usuario[0].ap_paterno + " " + ele.verificacion_usuario[0].ap_materno + " " + ele.verificacion_usuario[0].nombre;
                tipoUsuario = ele.verificacion_usuario[0].rol;
                Usu = ele.verificacion_usuario[0];
                UsuarioData.InsertUsuario(ele.verificacion_usuario[0]);
                DependencyService.Get<IFileHelper>().UnSuscribeTopic("Invitado");
                if (ele.verificacion_usuario[0].rol.Equals("acad_estudiante"))
                {
                    TemaTipo = "Estudiante";

                    await CargarCarrera(usus);
                }
                else
                {
                    TemaTipo = "Docente";

                    await CargarMateriasDocente(ele.verificacion_usuario[0]);
                }

                retu = true;


            }
            else { retu = false; }


        }
        private async Task CargarMateriasDocente(Verificacion_Usuario usuario)
        {
            var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_ListaMateriasDocente.php/?usuario_d={usuario.usuario}&gestion_d=2019&periodo_d=2");
            ArchivoJson = response.Content.ReadAsStringAsync().Result;
            var ele = JsonConvert.DeserializeObject<ListaMateriasDocente>(ArchivoJson);
            listaMateriasDocente = ele;
            TemaCarreraDocente = new string[ele.materias_docente.Length];
            TemaUnidadDocente = new string[ele.materias_docente.Length];
            TemaTurnoDocente = new string[ele.materias_docente.Length];
            await GuardarMateriaDocenteSQL(ele);
        }
        private async Task GuardarMateriaDocenteSQL(ListaMateriasDocente ele)
        {
            MateriaDocenteData.DeleteAll();
            for (int i = 0; i < ele.materias_docente.Length; i++)
            {
                TemaCarreraDocente[i] = CastearCarrera(ele.materias_docente[i].nombre_carrera);
                TemaTurnoDocente[i] = ele.materias_docente[i].turno;
                TemaUnidadDocente[i] = CastearUnidad(ele.materias_docente[i].subsede);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarreraDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTurnoDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaUnidadDocente[i]);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarreraDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaTurnoDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaTurnoDocente[i] + TemaUnidadDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaUnidadDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaTurnoDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaTurnoDocente[i] + TemaUnidadDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaUnidadDocente[i]);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarreraDocente[i] + TemaTurnoDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarreraDocente[i] + TemaUnidadDocente[i]);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarreraDocente[i] + TemaTurnoDocente[i] + TemaUnidadDocente[i]);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTurnoDocente[i] + TemaUnidadDocente[i]);
                MateriaDocenteData.InsertMateria(ele.materias_docente[i]);
            }
            await CargarListaAlumnos(ele.materias_docente);
        }

        private async Task CargarListaAlumnos(Materias_Docente[] mat_doc)
        {
            ListaEstudiantesData.DeleteAll();
            for (int i = 0; i < mat_doc.Length; i++)
            {

                var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_ListaEstudiantesMatDocente.php/?usuario_le={Usu.usuario}&id_mathab_le={mat_doc[i].id_materia_habilitada}");
                ArchivoJson = response.Content.ReadAsStringAsync().Result;
                var ele = JsonConvert.DeserializeObject<ListaEstudiantes>(ArchivoJson);
                ListaEstudiantesData.InsertAllLista(ele.lista_estudiantes_materia);
            }
        }

        public async Task CargarCarrera(string usuario_c)
        {
            var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_ListaCarrerasEstudiante.php/?usuario_c={usuario_c}");
            ArchivoJson = response.Content.ReadAsStringAsync().Result;
            carUsu = new Carrera_Usuario();
            var ele = JsonConvert.DeserializeObject<Carrera_Usuario>(ArchivoJson);
            if (ele.success == 1)
            {
                GuardarCarreraSQL(ele);
            }
            //Converting JSON Array Objects into generic list

        }
        private async void GuardarCarreraSQL(Carrera_Usuario carreras)
        {
            for (int i = 0; i < carreras.carreras_estudiante.Length; i++)
            {
                CarreraData.InsertCarrera(carreras.carreras_estudiante[i]);
                await CargarMaterias(carreras.carreras_estudiante[i].id_member_carrera);
            }

        }

        private async Task CargarMaterias(int id)
        {
            List<Verificacion_Usuario> data = UsuarioData.GetUsuarios();
            gestion = data[0].gestion;
            periodo = data[0].periodo;
            var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_ListaMateriasEstudiante.php/?id_mcarrera={id}&gestion=2019&periodo=2");
            ArchivoJson = response.Content.ReadAsStringAsync().Result;
            carUsu = new Carrera_Usuario();
            var ele = JsonConvert.DeserializeObject<Materia>(ArchivoJson);
            if (ele.materias_estudiante.Length > 0)
            {
                TemaTurno = ele.materias_estudiante[0].turno;
            }

            if (ele.success == 1)
            {
                GuardarMateriaSQL(ele);
            }
        }

        private async void GuardarMateriaSQL(Materia ele)
        {


            for (int i = 0; i < ele.materias_estudiante.Length; i++)
            {
                TemaCarrera = CastearCarrera(ele.materias_estudiante[i].nombre_carrera);
                TemaTurno = ele.materias_estudiante[i].turno;
                TemaUnidad = CastearUnidad(ele.materias_estudiante[i].unidad_academica);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarrera);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTurno);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaUnidad);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarrera);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarrera + TemaTurno);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaCarrera + TemaTurno + TemaUnidad);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaTurno);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaTurno + TemaUnidad);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTipo + TemaUnidad);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarrera + TemaTurno);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarrera + TemaUnidad);
                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaCarrera + TemaTurno + TemaUnidad);

                DependencyService.Get<IFileHelper>().SuscribeTopic(TemaTurno + TemaUnidad);
                MateriaData.InsertMateria(ele.materias_estudiante[i]);
                await CargarHorarios(ele.materias_estudiante[i].id_asigdoc);
            }
        }

        private async Task CargarHorarios(int id_asigdoc)
        {
            var response = await client.GetAsync($"http://107.21.33.126:81/app_movil/SQL_ListaHorariosAulasEstudiante.php/?id_asigdoc_e={id_asigdoc}");
            ArchivoJson = response.Content.ReadAsStringAsync().Result;
            var elem = JsonConvert.DeserializeObject<Horario>(ArchivoJson);
            if (elem.success == 1)
            {
                for (int i = 0; i < elem.horarios_aula_estudiante.Length; i++)
                {
                    HorarioData.InsertHorarios(elem.horarios_aula_estudiante[i]);
                }
            }

        }



        private string CastearUnidad(string unidad_academica)
        {
            string Unidad = unidad_academica;
            if (unidad_academica.Equals("EL ALTO-ANTIGUOS"))
            {
                Unidad = "ELALTO";
            }
            if (unidad_academica.Equals("EL ALTO"))
            {
                Unidad = "ELALTO";
            }
            if (unidad_academica.Equals("LA PAZ"))
            {
                Unidad = "LAPAZ";
            }
            return Unidad;

        }

        private string CastearCarrera(string nombre_carrera)
        {
            string carrera = nombre_carrera;
            switch (nombre_carrera)
            {
                case ("INGENIERIA ELECTRONICA"):
                    carrera = "INGELE";
                    break;
                case ("INGENIERIA EN ECOLOGIA Y MEDIO AMBIENTE"):
                    carrera = "INGECO";
                    break;
                case ("INGENIERIA DE SISTEMAS"):
                    carrera = "INGSIS";
                    break;
                case ("DERECHO"):
                    carrera = "DERECH";
                    break;
                case ("INGENIERIA CIVIL"):
                    carrera = "INGCIV";
                    break;
                case ("INGENIERIA COMERCIAL"):
                    carrera = "INGCOM";
                    break;
                case ("COMERCIO INTERNACIONAL"):
                    carrera = "COMINT";
                    break;
                case ("CONTADURIA PUBLICA"):
                    carrera = "CONPUB";
                    break;
                case ("ADMINISTRACION DE EMPRESAS"):
                    carrera = "ADMEMP";
                    break;
                case ("PROGRAMA COMPLEMENTARIO EN CONTADURIA PUBLICA"):
                    carrera = "CONPUB";
                    break;
                case ("MARKETING Y DIRECCION COMERCIAL"):
                    carrera = "MARKET";
                    break;
                case ("VENTAS Y COMERCIALIZACION"):
                    carrera = "VENCOM";
                    break;
                case ("COMUNICACIÓN Y TECNOLOGIAS DIGITALES"):
                    carrera = "COMTEC";
                    break;
                case ("TURISMO Y HOTELERIA"):
                    carrera = "TURHOT";
                    break;
                case ("PSICOLOGIA"):
                    carrera = "PSICOL";
                    break;
                case ("PROFESIONALIZACION EN ADUANAS Y COMERCIO EXTERIOR"):
                    carrera = "COMEXT";
                    break;
            }
            return carrera;
        }
    }
}
