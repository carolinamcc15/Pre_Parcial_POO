using System;

namespace Pre_Parcial_2
{
    public class Usuario
    {

        public int ID { set; get; }
        public  String Nombre {  set; get; }
        public String Contraseña { set; get;  }
        public bool EsAdmin { set; get;  }
        
        public Usuario(){}

        public Usuario(int ID, String Nombre, String Contraseña, bool EsAdmin)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
            this.EsAdmin = EsAdmin;
        }
    }
}