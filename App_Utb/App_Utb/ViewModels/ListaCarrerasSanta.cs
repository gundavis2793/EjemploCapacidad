using App_Utb.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.ViewModels
{
    public class ListaCarrerasSanta
    {
        public IList<CarreraSanta> CarrerasSanta { get; set; }
        public ListaCarrerasSanta()
        {
            CarrerasSanta = new List<CarreraSanta>();
            CarreraSanta Administracion = new CarreraSanta(
                    "Car14EncAdmi.jpg",
                    "Administracion de Empresas",
                    "Formar profesionales integrales con alto grado de responsabilidad y creatividad, comprometidos en el ejercicio de un liderazgo entusiasta, capaces de aplicar y desarrollar habilidades de dirección, comunicación en cualquier tipo de organización; asimismo, estarán aptos para la toma de decisiones acertadas y la adaptabilidad al cambio. Capaces de planificar, organizar, integrar, dirigir y controlar de manera eficiente y eficaz los recursos humanos, materiales y técnicos que apoyen en el logro de los objetivos estratégicos organizacionales, en las áreas de administración, finanzas, comercial, producción, operaciones, recursos humanos y sistemas, con actitud emprendedora, responsable y ética generando una cultura de continuo aprendizaje y apertura al cambio.",
                    "El profesional en Administración de Empresas será capaz de:\r \n \r \n•Diseñar objetivos a corto, mediano y largo plazo en los organismos sociales y sus áreas respectivas.\r \n \r \n •Analizar y rediseñar estructuras y procedimientos organizacionales tomando en cuenta el proceso y propósito de la organización.\r \n \r \n •Identificar las necesidades de las diferentes áreas funcionales y optimizar recursos.\r \n \r \n •Desarrollar la capacidad creativa, análisis de situaciones, conducción de gente y responsabilidad social.\r \n \r \n •Organizar grupos empresariales que contribuyan al fortalecimiento económico y social en los niveles regional, nacional e internacional.\r \n \r \n •Las habilidades de diagnosticar lo convierte en un agente de cambio y en un líder con actitud proactiva y emprendedora.",
                    "El campo laboral del Profesional en Administración de Empresas incluye:\r \n \r \n •Sector público: ministerios, entidades públicas centralizadas y descentralizadas, municipios, y corporaciones regionales, etc.\r \n \r \n •Sector privado: bancos, entidades financieras, hoteles, fábricas, comercios, laboratorios, compañías, etc.\r \n \r \n•Ejercicio libre de la profesión como consultor administrativo en áreas tales como: mercadotecnia, administración de la producción, planificación estratégica, administración de recursos humanos, investigación de mercados, finanzas, etc.\r \n \r \n • Actividades académicas y de investigación.",
                    "Al culminar el sexto semestre el estudiante podrá obtener el Título en Provisión Nacional como Técnico Superior emanado por el Ministerio de Educación en:\r \n \r \n•“ADMINISTRACIÓN COMERCIAL”.\r \n \r \n•Y al concluir el Décimo semestre el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n •“LICENCIADO EN ADMINISTRACIÓN DE EMPRESAS”.",
                    "MCAdmi1",
                    " ",
                    "Ico14CarAdmi.png",
                    "Licenciatura 4 Años",
                    "Licenciado en Administración de Empresas",
                    " ",
                    "#66676C");
            CarreraSanta IngeComercial = new CarreraSanta(
                     "Car6EncComercial.jpg",
                     "Ingenieria Comercial",
                     "En esta carrera se preparan profesionales para que planifiquen la comercialización de bienes y/o servicios de negocios de organizaciones públicas y privadas, nacional como internacional. Planteando alternativas de mejoramiento en su posición financiera, formulando estrategias de capitalización de oportunidades comerciales; empleando criterios de administración, análisis de la información, mercadotecnia y finanzas.",
                     "El profesional en Ingeniería Comercial será capaz de:\r \n \r \n•Emplear criterios referentes a la planificación, organización, dirección y control, en base a técnicas, procedimientos, normas, estrategias para el desarrollo empresarial, mejorando y / o transformando la gestión administrativa y operativa.\r \n \r \n•Medir las variables comerciales, financieras y administrativas en general para tomar decisiones de manera eficiente y eficaz en el ámbito de la comercialización, las finanzas y la administración en general de todo tipo de organizaciones.\r \n \r \n•Contar con una visión global y competencias comerciales que le permitan desarrollar objetivos estratégicos e innovadores de acuerdo a las exigencias del mercado nacional e internacional.\r \n\r \n •Conocer la realidad nacional y de su entorno, por lo cual es capaz de implementar estrategias de marketing y / o de negocios corporativos.",
                     "El Ingeniero Comercial cuyas menciones los hacen especialistas en las áreas de Gestión Financiera y Gestión Empresarial, puede desenvolverse en:\r \n \r \n•Instituciones financieras, empresas consultoras y unidades de análisis en los cargos de: gerencia general, financiera o comercial; analista financiero u oficial de negocios.\r \n \r \n•Empresas comerciales, industriales y de servicio en los cargos de: gerencia general, de comercialización, de marketing, de logística y como analista financiero y comercial.\r \n \r \n•Organismos internacionales e instituciones sin fines de lucro como: consultor y/ o analista económico, financiero y de mercado; gerencia general, comercial, financiera y otras.\r \n \r \n•Emprendimientos propios.\r \n \r \n•Actividades académicas y de investigación.",
                     "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n\r \n “INGENIERO COMERCIAL”.",
                     "MCComercial1",
                     "MCComercial2",
                     "Ico6CarIngComer.jpg",
                     "Licenciatura 4 Años",
                     "• Mención Gestión Financiera",
                     "• Mención Gestión Empresarial",
                     "#66676C");
            CarreraSanta Comercio = new CarreraSanta(
                "Car7EncComInter.jpg",
                "Comercio Internacional",
                "La carrera de Comercio Internacional ofrece una sólida formación en Administración y Negocios de alcance internacional, satisfaciendo las demandas de la globalización y de la cultura en temáticas de importación – exportación de bienes y servicios, dando énfasis a los negocios internacionales, zonas francas, logística de bienes, servicios, tecnologías y capitales, aplicando estrategias de negociación internacional que se implementan tanto en el ámbito local como global.",
                "El licenciado en Comercio Internacional es un profesional altamente competente que gestiona de forma íntegra una organización exportadora e importadora con un enfoque estratégico y a la vez operativo; cuenta con una visión global, alto espíritu emprendedor, sentido ético, actitud proactiva y profundo conocimiento de la globalización y su impacto. Es capaz de contribuir desde su lugar de trabajo en la internacionalización, expansión y desarrollo de la empresa.",
                "El licenciado en Comercio Internacional, cuyas menciones los hacen especialistas en las áreas de Negociación Internacional y Logística Internacional, puede desenvolverse como:\r \n \r \n•Gerente o ejecutivo del área comercial internacional a nivel superior, de pequeñas, medianas y grandes empresas o corporaciones privadas o públicas.\r \n \r \n•Analista de mercados y proyecciones de oferta y demanda en el mercado internacional.\r \n \r \n•Investigador sectorial o empresarial del área de comercio exterior y finanzas internacionales.\r \n \r \n•Consultor de empresas para la planificación de nuevas inversiones, con la realización de diagnósticos del área comercial de las empresas, para la adopción de políticas en el marco de la administración estratégica.\r \n \r \n•Investigador académico en cualquiera de las áreas de la teoría del comercio internacional.\r \n \r \n•Asesor comercial de grupos empresariales, sectores productivos, gobiernos regionales, nacionales y legaciones diplomáticas.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n\r \n “LICENCIADO EN COMERCIO INTERNACIONAL”.",
                "MCComInt1",
                "MCComInt2",
                "Ico7CarComercio.png",
                "Licenciatura 4 Años",
                "• Mención Negociación Internacional",
                "• Mención Logistica Internacional",
                "#66676C");
            CarreraSanta Derecho = new CarreraSanta(
                   "Car12EncDerecho.jpg",
                   "Derecho",
                   "La carrera de Derecho formará profesionales capaces de diseñar y dirigir estrategias legales para asesorar a las personas, empresas privadas o instituciones públicas en aspectos de legislación nacional e internacional en el marco de las relaciones contractuales, negociaciones, procesos judiciales y arbitrales, protegiendo sus intereses y logrando la satisfacción de sus necesidades, con un profundo compromiso ético, valores humanos, morales, responsabilidad social y de servicio.",
                   "El Licenciado en Derecho será capaz de desempeñarse como:\r \n \r \n •Asesor en todo asunto que requiera opinión jurídica(por ejemplo: en el ámbito de instituciones civiles, en empresas comerciales, etc.).Permitiéndole actuar como mediador o conciliador.\r \n \r \n •Funcionario Judicial(jueces, fiscales, defensores públicos y otras magistraturas).",
                   "El Licenciado en Derecho cuyas menciones los hacen especialistas tanto en el área Privada como Pública, podrá ejercer como:\r \n \r \n•Asesor Jurídico de empresas privadas, productoras de bienes y servicios; o que se dedican a la importación y exportación, al transporte y la contratación de seguros.\r \n \r \n •Asesor Jurídico dependiente o externo de entidades dedicadas a la intermediación financiera.\r \n \r \n •Asesor Jurídico de instituciones públicas.\r \n \r \n •Funcionario Judicial o del Ministerio Público.\r \n \r \n •Negociador internacional de comercio, ante entes privados y públicos.\r \n \r \n •Abogado en el ejercicio libre, representante en procesos judiciales del sector público, privado y particular.\r \n \r \n •Conciliador o árbitro en cualquier trámite de conciliación o arbitraje que se le convoque.\r \n \r \n •Asesor de comunidades indígenas en diferentes aspectos relacionados con el derecho comunitario.",
                   "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n •“LICENCIADO EN DERECHO”.",
                   "MCDerecho1",
                   "MCDerecho2",
                   "Ico12CarDerecho.png",
                   "Licenciatura 4 Años",
                   "• Mención Derecho Privado",
                   "• Mención Derecho Público",
                   "#66676C");
            CarreraSanta Contaduria = new CarreraSanta(
                "Car13EncConta.jpg",
                "Contaduria Publica",
                "La carrera de Contaduría Pública forma profesionales altamente capacitados en procesos, que orienten efectivamente a las empresas en el manejo de sus recursos económicos; los cuales les permitirán comprender y solucionar problemas correspondientes al área contable, a través de métodos, sistemas de información, procedimientos y normas de auditoría y control, forma de tributación en Bolivia, finanzas empresariales e internacionales, con la finalidad de lograr eficiencia y eficacia con todo lo relacionado con la gestión empresarial.",
                "El profesional de Contaduría Pública está altamente capacitado en Contabilidad, Finanzas y Auditoria, está preparado para:\r \n \r \n •Desarrollar  auditorías contables, financieras, tributarias, operativas y de gestión en todo tipo de entidad.\r \n \r \n •Asesorar, elaborar, analizar, proyectar, revisar e interpretar la información económica financiera de empresas privadas, públicas y mixtas.\r \n \r \n •Orientar  con enfoques claros del costo beneficio de todas las actividades empresariales en función de la situación financiera de una entidad.\r \n \r \n •Resolver problemas o dificultades financieras.",
                "El campo laboral para el Contador Público abarca:\r \n \r \n •Entidades públicas y privadas desde cargos operativos a gerenciales, relacionados con finanzas y administración.\r \n •Entidades sin fines de lucro a cargo de la proyección, ejecución y  elaboración de productos financieros finales.\r \n •Auditoría y contabilidad externa e interna de empresas y organizaciones.\r \n •Asesoramiento externo a diversas carteras de clientes.",
                "Al culminar el sexto semestre el estudiante podrá obtener el Título en Provisión Nacional como Técnico Superior emanado por el Ministerio de Educación en:\r \n \r \n •“CONTADOR GENERAL”.\r \n \r \n •Y al concluir el Décimo semestre el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n •“LICENCIADO EN CONTADURÍA PÚBLICA”.",
                "MCConta1",
                " ",
                "Ico13CarConta.png",
                "Licenciatura 4 Años",
                "• Licenciado en COntaduría Publica",
                " ",
                "#66676C");
            CarrerasSanta.Add(Administracion);
            CarrerasSanta.Add(IngeComercial);
            CarrerasSanta.Add(Comercio);
            CarrerasSanta.Add(Derecho);
            CarrerasSanta.Add(Contaduria);
        }
        public IList<CarreraSanta> GetAll()
        {
            return (CarrerasSanta);
        }
    }
}
