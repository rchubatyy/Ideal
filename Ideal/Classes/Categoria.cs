namespace Ideal.Classes
{
    class Categoria
    {
        //Atributos
        private int _id;
        private string _tipo;

        //Construtor
        public Categoria(int id,string tipo)
        {
            _id = id;
            _tipo = tipo;
        }

        public Categoria(string tipo)
        {
            _id = 0;
            _tipo = tipo;
        }

        //Metodos set/get
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
