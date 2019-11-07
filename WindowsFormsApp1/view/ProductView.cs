namespace WindowsFormsApp1.data
{
    public class ProductView
    {
        public string Name { get; set; }
        public string Tipo { get; set; }
        public string Classe { get; set; }
        public float Calorias { get; set; }

        public override string ToString()
        {
            return "Nome: " + Name + ", Tipo: " + Tipo + ", Classe: " + Classe + ", Calorias: " + Calorias;
        }
    }
}