using System.Collections.Generic;

namespace App_Utb
{
    public class ListaCarreras
    {
        //clase ListaNoticias que tiene como atributo una lista de noticias 
        public IList<Carrera> Carreras { get; set; }
        public ListaCarreras()
        {
            Carreras = new List<Carrera>();
            Carrera ventasyComercializacion = new Carrera(
                "Car1EncVentas.jpg",
                "Ventas y Comercialización",
                "La carrera de Ventas y Comercialización forma profesionales idóneos, altamente competitivos, emprendedores en la Gestión de Ventas y de Comercialización, de alto nivel académico y científico, conscientes e identificados con su realidad; con capacidad y conocimientos teórico-prácticos, que le permitan planificar, diseñar, organizar, ejecutar, evaluar y proyectar políticas, estrategias y acciones específicas comerciales, de ventas y comercialización adecuadas a las necesidades económicas, políticas, sociales y ambientales, tanto a nivel local, regional y global de un bien o servicio en empresas, organismos e instituciones públicas o privadas entre otras. Fomentando la creatividad e iniciativa y el trabajo en equipo, para el desarrollo de sus propios emprendimientos.",
                "El profesional en Ventas y Comercialización será capaz de: \r \n \r \n•Contar con los conocimientos especializados en las diferentes áreas administrativas de las ventas y de la comercialización, de acuerdo a los requerimientos de la actividad económica, del medio y el avance del estudio y técnicas de mercadeo y comerciales, que le permitan identificar problemas y plantear cursos alternativos de acción, tendientes al ajuste, transformación o rediseño de los procesos de comercialización y ventas de las organizaciones públicas y privadas.\r \n\r \n•Identificar a través de investigaciones, las necesidades, condiciones y requerimientos de los consumidores.Que permita el diseño de estrategias para proporcionar oportuna y adecuadamente los bienes y servicios que aseguren su satisfacción, así como el logro de los objetivos de la empresa a la que pertenecen.",
                "El licenciado en Ventas y Comercialización, está en capacidad para desempeñarse como empresario ejecutivo o consultor en múltiples áreas y campos de las organizaciones, según los énfasis que ofrece la carrera: Creación y Desarrollo de Empresas, Negocios Internacionales, Mercadeo Estratégico y Finanzas. En este sentido se puede desempeñar en las siguientes áreas:\r \n•Ventas Locales e Internacionales y Comercio Exterior\r \n\r \n•Negociación Internacional.\r \n•Inteligencia de Mercados Internacionales e Investigación de Mercados.\r \n\r \n•Talento Humano y Servicio al Cliente.\r \n\r \n•Logística y calidad.Finanzas y Formulación y Evaluación de Proyectos.\r \n\r \n•Comercialización.\r \n\r \n•Distribución y Desarrollo de Productos.\r \n\r \n•Negocios Virtuales a través del E - commerce.\r \n\r \n•Desarrollar Logística Digital.\r \n\r \n•Promover la Gestión Financiera en entornos Digitales para iniciativas de Ventas.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n\r \n“LICENCIADO EN VENTAS Y COMERCIALIZACIÓN”.",
                "MCVentas2",
                "MCVentas3",
                "Ico1CarVentas.jpg",
                "Licenciatura 4 Años",
                "• Mención Dirección Comercio Electrónico",
                "• Mención Dirección Estrategica de Ventas",
                "DarkGreen");

            Carrera ComunicacionyTecnologiasDigitales = new Carrera(
                "Car2EncComunicacion.jpg",
                "Comunicacion y Tecnologias Digitales",
                "La carrera de Comunicación y Tecnologías Digitales, forma profesionales que manejen herramientas que ofrecen las nuevas tecnologías en comunicación, relacionadas a la publicidad, el marketing, investigación de mercado, los medios de producción entre otros que servirán para diseñar, planificar, producir y/o dirigir estrategias de comunicación con un enfoque dirigido a las estrategias digitales con soporte multimedia.",
                "El licenciado en Comunicación y Tecnologías Digitales es un profesional con habilidades, destrezas, creativo, gestor de contenidos en diferentes soportes y medios digitales, capaz de diseñar, desarrollar medios, mensajes, estrategias, actualización de materiales online, políticas multimedia y plataformas interactivas para la consecución del bienestar de la sociedad.",
                "El licenciado en Comunicación y Tecnologías Digitales podrá desempeñarse en:El licenciado en Comunicación y Tecnologías Digitales podrá desempeñarse en:\r \n •Producción y Dirección Audiovisual, Multimedia, Comunicación Online, Soportes Multimedia, Comunicación Interactiva, Producción y Post Producción en televisión, radio y prensa.\r \n \r \n• Educomunicación, Eco comunicación, Imagologìa, comunicación para el cambio social, gestión educativa de medios y nuevas tecnologías.\r \n\r \n •Periodismo: Político, Investigación, Deportivo, Económico, Periodista Especializado en Tecnologías Digitales, Periodista Especializado en Negociación y Resolución de Conflictos.\r \n \r \n•Comunicación corporativa, relaciones públicas, comunicación empresarial, cultura organizacional, identidad e imagen corporativa, Publicidad Venta y Marketing.\r \n \r \n•Asesoría en el manejo eficiente de medios de comunicación, promoción y posicionamiento de marcas empresariales.\r \n \r \n•Investigación y critica, planificación estratégica, consultoría, análisis de medios y tendencias, sistematización de datos.\r \n \r \n•Coordinación de campañas publicitarias, centros de información, analista de mercados digitales.\r \n \r \n•Dirigir y manejar instituciones con nuevas tecnologías en la educación.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n“LICENCIADO EN COMUNICACIÓN Y TECNOLOGÍAS DIGITALES”.",
                "MCComunicacion1",
                " ",
                "Ico2CarComunicacion.jpg",
                "Licenciatura 4 Años",
                "• Licenciado en Comunicación y Tecnologias Digitales",
                " ",
                "DarkGreen");
            Carrera Marketing = new Carrera(
                "Car3EncMarketing.jpg",
                "Marketing y Direccion Comercial",
                "La carrera de Marketing y Dirección Comercial forma profesionales responsables de analizar necesidades específicas de mercadotecnia, publicidad de negocios, liderar Proyectos de Marketing nacionales o internacionales, definir políticas y estrategias comerciales; proponiendo modelos de operación para la toma de decisiones que permitan dirigir y gerenciar el área comercial de una organización con la capacidad de interpretar al consumidor con los aportes del Neuromarketing. Obteniendo el máximo beneficio del mercado a través de las aptitudes directivas y empresariales, junto con las nuevas tecnologías de comunicación que sirven de soporte para la Gestión de Marketing de todo emprendimiento.",
                "El profesional en Marketing y Dirección Comercial será capaz de:El profesional en Marketing y Dirección Comercial será capaz de:\r \n •Poseer un alto sentido de creatividad y un razonamiento estratégico para tomar decisiones.\r \n •Manejar y evaluar información cualitativa y cuantitativa.\r \n •Poseer un elevado grado de responsabilidad, justicia y sensibilidad social.\r \n \r \n•Contar con un grado alto de valores éticos y morales.\r \n \r \n•Motivar y realizar trabajos con equipos multidisciplinarios.\r \n\r \n •Criticar y analizar sobre los fenómenos, sociales, organizacionales y empresariales.\r \n \r \n•Buscar la mejora continua, tanto en el ámbito personal como en la organización donde interactúe. \r \n \r \n•Manejar medios de comunicación.\r \n \r \n•Generar e innovar emprendimientos empresariales.",
                "El licenciado en Marketing y Dirección Comercial cuyas menciones los hacen especialistas en las áreas de Comunicación Estratégica y Marketing Digital, podrá desempeñarse como:El licenciado en Marketing y Dirección Comercial cuyas menciones los hacen especialistas en las áreas de Comunicación Estratégica y Marketing Digital, podrá desempeñarse como:\r \n \r \n•Investigador de Mercados.\r \n \r \n•Analista de Inteligencia de Mercados.\r \n \r \n•Coordinador de Mercadotecnia.\r \n\r \n •Director de Mercadotecnia Internacional.\r \n \r \n•Gerente de Marca.\r \n \r \n•Planeador Estratégico.\r \n \r \n•Ejecutivo de Cuentas.\r \n \r \n•Coordinador de Relaciones Públicas.\r \n \r \n•Creador de Campañas Publicitarias.\r \n \r \n•Gerente de Desarrollo de Proyectos.\r \n \r \n•Representante de Mercadotecnia Internacional.\r \n \r \n•Consultor de Marketing.\r \n \r \n•Especialista en Desarrollo de Producto.\r \n \r \n•Gerente de Ventas.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n“LICENCIADO EN MARKETING Y DIRECCIÓN COMERCIAL”.",
                "MCMarketing1",
                "MCMarketing2",
                "Ico3CarMarketing.jpg",
                "Licenciatura 4 Años",
                "• Mención Comunicación Estratégica",
                "• Mención Marketing Digital",
                "DarkGreen");
            Carrera PSicologia = new Carrera(
                "Car4EncPsicologia.jpg",
                "Psicología",
                "La carrera de Psicología otorga una sólida formación para ser capaz de articular conocimientos y competencias para la evaluación, diagnóstico, tratamiento, asesoramiento, prevención y orientación de las problemáticas de orden psicológico, en la dinámica educativa, hospitalaria, empresarial y legal en procesos que involucren personas, grupos y organizaciones. Asimismo, puede desarrollarse en el campo de la investigación y en el trabajo con equipos interdisciplinarios.",
                "El profesional en Psicología será capaz de:El profesional en Psicología será capaz de:\r \n \r \n•Ser un generador de cambio mediante el diseño, implementación y evaluación de propuestas de acción que contribuyan al bienestar personal y social, considerando valores éticos, sociales y culturales.\r \n\r \n •Diagnosticar, diseñar, implementar y evaluar intervenciones psicológicas que permitan contribuir a la prevención, promoción, tratamiento y seguimiento de problemas psicológicos de individuos, grupos y organizaciones; en una acción reflexiva sobre los alcances, límites y responsabilidad del propio rol profesional(clínico, educacional, organizacional).\r \n \r \n•Propiciar el análisis de los procesos psicológicos y los sistemas teóricos del área de la Psicología que explican la conducta individual y social.\r \n \r \n•Promover, ejecutar y evaluar la participación de los actores sociales para el desarrollo de propuestas de acción en el área jurídico – legal que contribuyan al bienestar personal y social privilegiando la atención a grupos vulnerables.\r \n \r \n•Integrar, planificar, administrar y evaluar un equipo interdisciplinario, permitiendo el uso compartido de conocimientos a partir de los requerimientos del entorno y de las necesidades de sus integrantes.\r \n \r \n•Favorecer el desarrollo del comportamiento actitudinal que propicie: el aprender a aprender, el aprender a emprender, el aprender a ser, el aprender a convivir y la formación del ser de manera integral.\r \n \r \n•Fomentar la investigación académica mediante la recolección de información empírica para la elaboración de diagnósticos precisos de problemas en el ámbito de acción de la disciplina.",
                "El licenciado en Psicología cuyas menciones los hacen especialistas en las áreas de Psicología Empresarial y Psicología Legal, podrá desempeñarse en:\r \n \r \n•Hospitales y centros de salud, tribunales de justicia, empresas públicas y privadas.\r \n\r \n •Centros de rehabilitación social, centros de readaptación social, hogares de niños y adolescentes.\r \n \r \n•En instituciones educativas, en las áreas de dirección, investigación y  evaluación educativa así como la docencia.\r \n\r \n •Asesoría y consultoria a organizaciones.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n“LICENCIADO EN PSICOLOGÍA”.",
                "MCPsicologia1",
                "MCPsicologia2",
                "Ico4CarPsicologia.jpg",
                "Licenciatura 4 Años",
                "• Mención Psicología Empresarial",
                "• Mención Psicología Legal",
                "DarkGreen");
            Carrera Turismo = new Carrera(
                 "Car5EncTurismo.jpg",
                 "Turismo y Hoteleria",
                 "La carrera de Turismo y Hotelería forma profesionales que serán capaces de implementar sus conocimientos en todas las áreas del turismo con una sólida formación en aspectos claves como Gestión Empresarial, Social y Marketing, aprendiendo a proyectar, comercializar y proponer estrategias competitivas para mejorar las condiciones de atención y promoción de los servicios turísticos, fortaleciendo la economía local regional y nacional del país tanto en lo económico como en lo cultural.",
                 "El profesional en Turismo y Hotelería está preparado para:\r \n \r \n•Formular, elaborar y evaluar proyectos turísticos y hoteleros.\r \n \r \n•Coordinar equipos interdisciplinarios de planeamiento del desarrollo de los sectores turístico y recreativo.\r \n \r \n•Planificar, organizar, dirigir y controlar las actividades en áreas de competencia de nivel público y privado.\r \n \r \n•Coordinar la toma de inventario, puesta en valor y determinación de acciones de preservación del patrimonio turístico, cultural y natural.\r \n \r \n•Organizar, coordinar y administrar instituciones prestadoras de servicios turísticos y hoteleros.\r \n \r \n•Planificar y dirigir actividades recreativas destinadas tanto a grupos específicos como a la población en general.\r \n \r \n•Organizar y coordinar eventos singulares, tales como ferias, congresos y reuniones.\r \n\r \n •Utilizar las Tecnologías de Información y de Comunicación adecuadas a la prestación de servicios y productos del sector turístico y hotelero.\r \n\r \n •Diseñar, gestionar e implementar proyectos, planes y programas de desarrollo turístico sustentable, que favorezcan el crecimiento ordenado de la actividad turística y hotelera.",
                 "El Licenciado en Turismo y Hotelería, cuyas menciones los hacen especialistas en las áreas de Gestión Empresarial Turística y Gestión Empresarial Hotelera podrá desempeñarse en:\r \n \r \n•Investigar, diagnosticar y promover el Turismo a través de planes, proyectos y programas de desarrollo.\r \n \r \n•Brindar asistencia y asesoramiento al sector turístico a través de procedimientos técnicos adecuados incluyendo el análisis de impacto de su utilización.\r \n \r \n•Asesorar, planificar y ejecutar planes de comunicación turística.\r \n \r \n•Determinar los criterios de calidad de servicios.\r \n \r \n•Organizar y dirigir departamentos de desarrollo de producto, comerciales o de investigación.\r \n \r \n•Seleccionar e implementar sistemas operativos de calidad.\r \n \r \n•Gerenciar empresas prestadoras de servicios turísticos u hoteleros.\r \n \r \n•Museos, Parques Naturales, oficinas Gubernamentales de Turismo.\r \n\r \n •Empresas consultoras del sector turístico y hotelero.\r \n \r \n•Crear su propia empresa de servicios turísticos y hoteleros.",
                 "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n“LICENCIADO EN TURISMO Y HOTELERÍA”.",
                 "MCTurismo1",
                 "MCTurismo2",
                 "Ico5CarTurismo.png",
                 "Licenciatura 4 Años",
                 "• Mención Gestión Empresarial Turística",
                 "• Mención Gestión Empresarial Hotelera",
                 "DarkGreen");
            Carrera IngeComercial = new Carrera(
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
            Carrera Comercio = new Carrera(
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
            Carrera IngeElectronica = new Carrera(
                "Car8EncElectronica.jpg",
                "Ingenieria Electronica",
                "El Ingeniero en Electrónica adquiere sólidos conocimientos en las áreas de electrónica digital-analógica, telecomunicaciones, control y automatización para la implementación de sistemas electrónicos basados en microcontroladores, dispositivos lógicos programables, circuitos integrados; éstas destrezas son suficientes como para desarrollarse en la especialización de la automatización industrial así como en la generación de redes en telecomunicaciones. Permitiendo a nuestro profesional encontrar soluciones en escenarios altamente competitivos.",
                "El Ingeniero Electrónico es un profesional capaz de:\r \n \r \n•Diseñar, construir y mantener sistemas electrónicos, considerando requerimientos de desempeño y sustentabilidad tales como velocidad, confiabilidad, costo y ahorro de energía.\r \n \r \n•Desarrollar tecnología de acuerdo a los requerimientos de la industria.\r \n \r \n•Implementar sistemas electrónicos análogos y digitales.\r \n \r \n•Diseñar, instalar y mantener sistemas electrónicos.\r \n \r \n•Contribuir a los avances de la ciencia y dinámica tecnológica.",
                "El Ingeniero Electrónico cuyas menciones los hacen especialistas en las siguientes áreas: Industrial y Telecomunicaciones. Está capacitado para trabajar en el área industrial, agroindustrial, alimentos, textiles, mineras, petroleras y toda empresa que cuente con equipamiento electrónico y/o industrial. Puede desempeñarse en los siguientes cargos:\r \n \r \n•Gerente Técnico.\r \n \r \n•Integrador de Tecnología implementando proyectos de automatización industrial.\r \n \r \n•Desarrollador de sistemas de telecomunicaciones en empresas públicas y privadas.\r \n \r \n•Diseñador y proyectista de instalaciones eléctricas y electrónicas.\r \n \r \n•Jefe de mantenimiento de instalaciones eléctricas industriales.\r \n \r \n•Jefe de mantenimiento y control eléctrico de motores.\r \n \r \n•Consultor y asesor técnico independiente.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n“INGENIERO ELECTRÓNICO”.",
                "MCElectrica1",
                "MCElectrica2",
                "Ico8CarElectronica.png",
                "Licenciatura 4 Años",
                "• Mención Industrial",
                "• Mención Telecomunicaciones",
                "#66676C");
            Carrera ingeSistemas = new Carrera(
                  "Car9EncSistemas.jpg",
                  "Ingenieria de Sistemas",
                  "La carrera de Ingeniería de Sistemas ofrece la capacitación profesional en ciencias computacionales, ingeniería de software, sistemas de información, redes, infraestructura computacional y administración de proyectos informáticos, capaz de desempeñarse con criterio científico-técnico, en análisis de diseño, desarrollo, ejecución, evaluación, control, mantenimiento, dirección e integración de los mismos; haciendo énfasis en las áreas de tecnologías de producción y tecnologías de información, mismas que permiten a nuestro profesional tener una visión innovadora que abre oportunidades y genera ventajas competitivas en cualquier organización.",
                  "El Ingeniero de Sistemas será capaz de desempeñarse como:\r \n \r \n•Experto en desarrollo de sistemas informáticos.\r \n \r \n•Planificador y diseñador de sistemas administrativos así como sistemas de comunicación por redes.\r \n\r \n •Asesor para la adquisición de nuevas tecnologías informáticas.\r \n \r \n•Gerente de sistemas de una empresa moderna caracterizada por la automatización de sus procesos.\r \n \r \n•Administrador de los recursos computacionales tanto de datos como equipamientos instalados en la empresa.\r \n \r \n•Consultor en el área tecnológica, diseñador, implementador y administrador de infraestructuras de red a la medida de la empresa.\r \n \r \n•Desarrollador de aplicaciones utilizando tecnología de vanguardia que resuelvan problemas en la ciencia, la industria, la educación y el entretenimiento, con una visión internacional de la sociedad y sus requerimientos culturales.",
                  "El Ingeniero de Sistemas cuyas menciones los hacen especialistas en las áreas de Tecnologías de Producción e Información. Puede desarrollarse en cualquier tipo de organización dentro del sector productivo, manufacturero, financiero, gubernamental, salud, educativo y de servicios, entre otros, se podrá desempeñar como:\r \n \r \n•Jefe de Proyectos de Sistemas.\r \n\r \n •Consultor Informático, capaz de asesorar en la identificación de oportunidades informáticas para la solución de problemas.\r \n \r \n•Director de Sistemas, a cuyo cargo están todos los servicios informáticos de una organización.\r \n \r \n•Administrador de servicios informáticos, capaz de articular éstos con los recursos de una organización.\r \n \r \n•Desarrollador de Sistemas Informáticos, capaz de analizar, diseñar, programar, operar y controlar sistemas informáticos.\r \n \r \n•Auditor de Sistemas.\r \n \r \n•Gerente de Proyectos de Producción",
                  "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n“INGENIERO EN SISTEMAS”.",
                  "MCSistemas1",
                  "MCSistemas2",
                  "Ico9CarSistemas.png",
                  "Licenciatura 4 Años",
                  "• Mención Tecnologías de Producción",
                  "• Mención TEcnologías de Información",
                  "#66676C");
            Carrera IngeCivil = new Carrera(
                "Car10EncCivil.jpg",
                "Ingenieria Civil",
                "La carrera de Ingeniería Civil tiene como objetivo formar profesionales innovadores y capaces de planear, diseñar, modelar, administrar, construir y mantener diversos tipos de proyectos de obras públicas y/o privadas; utilizando eficientemente los recursos energéticos y considerando el cuidado del medio ambiente, en beneficio de la comunidad. Se enfoca en estructuras e instalaciones, como las rutas de transporte (túneles, puentes, pasos elevados, carreteras), centros (tales como aeropuertos, terminal de buses), tratamiento de agua (aguas residuales, presas, oleoductos, etc.), edificaciones gubernamentales y otras estructuras necesarias.",
                "El Ingeniero Civil es un profesional capaz de:\r \n \r \n•Aplicar las ciencias e ingeniería básicas en la solución de problemas de las áreas propias de la Ingeniería Civil: Estructuras, Hidráulica, Ingeniería Ambiental, Vías de Comunicación, Administración de la Construcción y Materiales.\r \n \r \n•Identificar, formular y resolver problemas en las diversas áreas de la Ingeniería Civil utilizando las mejores prácticas y avances tecnológicos en un marco de desarrollo sostenible.\r \n \r \n•Ser líder y participar eficientemente en equipos de trabajo multidisciplinarios en el desarrollo de proyectos en las diversas áreas.\r \n \r \n•Formular propuestas técnicas y económicas para participar en las licitaciones de obras públicas y privadas.\r \n \r \n•Aplicar normas nacionales o internacionales inherentes a las áreas propias de Ingeniería Civil.\r \n \r \n•Realizar estudios de factibilidad técnico - económica y diseño final de proyectos de obras civiles.\r \n \r \n•Transformar ideas complejas en realidades concretas.",
                "El Ingeniero Civil cuyas menciones los hacen especialistas; por un lado en las áreas de Estructuras y Vías y por otro en Hidráulica y Sanitarias. Está capacitado para realizar estudios de factibilidad, proyectos, dirección, inspección, auditoria, construcción, operación, mantenimiento, control, reparación y readecuación de:\r \n \r \n•Obras de regulación, captación, abastecimiento y tratamiento de aguas; aprovechamiento de la energía hidráulica y otras fuentes alternativas.\r \n \r \n•Obras de corrección y regulación fluvial.\r \n \r \n•Obras de saneamiento urbano, rural y regional.\r \n \r \n•Obras de urbanismo en lo referente al trazado urbano, y organización de los servicios públicos vinculados con higiene, transporte, comunicaciones y energía.\r \n \r \n•Trabajos topográficos, geodésicos, cartográficos y de catastro.\r \n \r \n•Planeación urbana, rural y de sistemas de transporte en general.\r \n •Construcción de obras civiles, ya sea como proyectista o como ejecutor de las obras.",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n •“INGENIERO CIVIL”.",
                "MCCivil1",
                "MCCivil2",
                "Ico10CarCivil.png",
                "Licenciatura 4 1/2 Años",
                "• Mención Estructuras y Vias",
                "• Mención Hidráulica y Sanitarias",
                "#66676C");
            Carrera IngeEco = new Carrera(
                "Car11EncEcologia.jpg",
                "Ingenieria en Ecología y Medio Ambiente",
                "La carrera de Ingeniería en Ecología y Medio Ambiente prepara profesionales de la más alta calidad científica-humanística, creativos, innovadores, emprendedores y comprometidos con la conservación, recuperación y preservación ambiental, altamente capacitados en el estudio de la diversidad de ecosistemas, la gestión ambiental y el ecoturismo sostenible. Mediante la búsqueda y aplicación de tecnología de punta que favorezca el desarrollo sostenible, la elevación de la calidad de vida y el bienestar social.",
                "El profesional en Ecología y Medio Ambiente es capaz de:\r \n \r \n •Desarrollar sistemas de prevención de impactos ambientales negativos actuales y potenciales, diagnosticando, adaptando y aplicando técnicas educativas de protección del medio ambiente.\r \n \r \n•Plantear sistemas de control y monitoreo de los parámetros ambientales, realizando evaluaciones y utilizando datos sobre actividades, obras y proyectos meteorológicos capaces de alterar la calidad ambiental.\r \n\r \n •Desarrollar sistemas de mitigación y restauración de componentes ambientales afectados por actividades antrópicas o contingencias naturales, adaptando y aplicando tecnologías apropiadas para los casos específicos.\r \n \r \n•Generar planes, programas y proyectos de Evaluación de Impacto Ambiental y a la vez de Control de Calidad Ambiental.\r \n \r \n•Gestionar y evaluar proyectos de índole ecoturístico; la operación de productos y servicios turísticos de calidad en el área del turismo de la naturaleza, conservando el ambiente y mejorando el bienestar de la población objetivo.",
                "El Ingeniero en Ecología y Medio Ambiente cuyas menciones los hacen especialistas en las áreas de Ecoturismo Sostenible y Gestión Ambiental, se podrá desempeñar como:\r \n \r \n •Consultor en la evaluación ambiental de obras, actividades y proyectos.\r \n \r \n•Consultor en la prevención, mitigación y control de la contaminación de factores ambientales.\r \n \r \n•Técnico en sistemas de tratamiento de aguas residuales, gestión de residuos sólidos y análisis de suelos.\r \n \r \n•Asesor, supervisor y auditor ambiental.\r \n \r \n•Investigador experto en temáticas ambientales.\r \n \r \n•Agente operativo, consultor de viajes, planificador y gestor de destinos en ecoturismo",
                "Al concluir la carrera el estudiante podrá obtener el Título en Provisión Nacional emanado por el Ministerio de Educación como:\r \n \r \n •“INGENIERO EN ECOLOGÍA Y MEDIO AMBIENTE”.",
                "MCEcologia1",
                "MCEcologia2",
                "Ico11CarAmbiental.png",
                "Licenciatura 4 Años",
                "• Mención Gestión Ambiental",
                "• Mención Ecoturismo Sostenible",
                "#66676C");
            Carrera Derecho = new Carrera(
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
            Carrera Contaduria = new Carrera(
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
            Carrera Administracion = new Carrera(
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
            Carreras.Add(ComunicacionyTecnologiasDigitales);
            Carreras.Add(Marketing);
            Carreras.Add(PSicologia);
            Carreras.Add(Turismo);
            Carreras.Add(ventasyComercializacion);
            Carreras.Add(Administracion);
            Carreras.Add(Comercio);
            Carreras.Add(Contaduria);
            Carreras.Add(Derecho);
            Carreras.Add(IngeCivil);
            Carreras.Add(IngeComercial);
            Carreras.Add(IngeEco);
            Carreras.Add(IngeElectronica);
            Carreras.Add(ingeSistemas);

        }
        //metodo que retorna el atributo lista con todos sus elementos
        public IList<Carrera> GetAll()
        {
            return (Carreras);
        }

    }
}