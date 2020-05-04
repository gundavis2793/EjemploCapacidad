using App_Utb.Modelos;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Utb.Helpers
{
    public class FirebaseHelper
    {


        FirebaseClient firebase = new FirebaseClient("https://aplicacion-utb-d4b9c.firebaseio.com/");
        public async Task<List<Notificacion>> GetAllNotificaciones()
        {
            string data = "Invitado";
            string FileUsu = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            if (!File.Exists(FileUsu))
            {
                data = "Invitado";
            }
            else
                data = File.ReadAllText(FileUsu);
            return (await firebase
                .Child("Notificacion")
                .OnceAsync<Notificacion>()).Select(item => new Notificacion
                {
                    titulo = item.Object.titulo,
                    mensaje = item.Object.mensaje,
                    grado = item.Object.grado,
                    fecha = item.Object.fecha,
                    segmentacion=item.Object.segmentacion,
                }
                ).ToList();

        }
        //public async Task<List<Usuario>> GetAllUsuarios()
        //{
        //    return (await firebase.Child("Usuario")
        //        .OnceAsync<Usuario>()).Select(item => new Usuario
        //        {
        //            Contrasena = item.Object.Contrasena,
        //            Cod = item.Object.Cod,
        //            Nombre = item.Object.Nombre,
        //            TipoUsuario = item.Object.TipoUsuario,
        //            MatPrimerSem = item.Object.MatPrimerSem,
        //            MatSup = item.Object.MatSup

        //        }).ToList();
        //}

        public async Task<Notificacion> GetUsuario(string tipo)
        {
            try
            {
                var allUsers = await GetAllNotificaciones();
                await firebase
                .Child("Notificacion")
                .OnceAsync<Notificacion>();
                return allUsers.Where(a => a.segmentacion.Equals(tipo)).LastOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }
        //public async Task<Notificacion> GetUsuario(string tipo)
        //{
        //    try
        //    {
        //        var allUsers = await GetAllNotificaciones();
        //        await firebase
        //        .Child("Usuario")
        //        .OnceAsync<Notificacion>();
        //        return allUsers.Where(a => a.mensaje.Equals(tipo)).FirstOrDefault();
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine($"Error:{e}");
        //        return null;
        //    }
        //}



        //public async Task<bool> UpdateUsuario(string cod, string password)
        //{
        //    try
        //    {


        //        var toUpdateUser = (await firebase
        //        .Child("Usuario")
        //        .OnceAsync<Usuario>()).Where(a => a.Object.Cod == cod).FirstOrDefault();
        //        await firebase
        //        .Child("Usuario")
        //        .Child(toUpdateUser.Key)
        //        .PutAsync(new Usuario() { Cod = cod, Contrasena = password });
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine($"Error:{e}");
        //        return false;
        //    }
        //}
    }
}
