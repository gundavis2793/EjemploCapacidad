namespace App_Utb
{
    public class MenuItem
    {
        public string texto { get; set; }
        public string recurso { get; set; }
        public MenuItem(string texto, string recurso)
        {
            this.texto = texto;
            this.recurso = recurso;
        }
    }
}
