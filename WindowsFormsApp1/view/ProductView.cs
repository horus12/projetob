namespace WindowsFormsApp1.data
{
    public class ProductView
    {
        public string Name { get; set; }
        public float CaloriasTotais { get; set; }
        
        public float Qtd { get; set; }

        public override string ToString()
        {
            return "Nome: " + Name + ", Quantidade " + Qtd +  ", Calorias Totais: " + CaloriasTotais;
        }
    }
}