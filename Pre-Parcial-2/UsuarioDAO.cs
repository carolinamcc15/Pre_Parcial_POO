using System;
using System.Collections.Generic;
using System.Data;

namespace Pre_Parcial_2
{
    public static class UsuarioDAO
    {
        public static void InsertUser(Usuario usuario)
        {
            String querySQL = $"INSERT INTO USUARIO" +
                              $" Values ('{usuario.Nombre}'," +
                              $"'{usuario.Contraseña}'," +
                              $"{usuario.EsAdmin});";
            DBConnection.ExecuteNonQuery(querySQL);
        }

        public static List<Usuario> getUsers()
        {
            String query = "SELECT * FROM USUARIO;";
            DataTable tabla = DBConnection.ExecuteQuery(query);
            var listaUsuarios = new List<Usuario>();
            foreach (DataRow fila in tabla.Rows)
            {
                Usuario usuarioAuxiliar = new Usuario();
                usuarioAuxiliar.Nombre = fila[0].ToString();
                usuarioAuxiliar.Contraseña = fila[1].ToString();
                usuarioAuxiliar.EsAdmin = Convert.ToBoolean(fila[2].ToString());
                listaUsuarios.Add(usuarioAuxiliar);
            }

            return listaUsuarios;
        }

        public static void ModifyUser(Usuario user, String primaryKey)
        {
            //UPDATE USUARIO set nombre = 'Carolina Carranza' WHERE NOMBRE = 'Carolin Carranza';
            String querySQL = $"UPDATE USUARIO SET nombre = " +
                              $"'{user.Nombre}'," +
                              $" contrasena = '{user.Contraseña}'," +
                              $" administrador = {user.EsAdmin}" +
                              $" WHERE NOMBRE = '{primaryKey}';";
            DBConnection.ExecuteNonQuery(querySQL);
        }

        public static void DeleteUser(Usuario user)
        {
            String querySQL = $"DELETE FROM USUARIO WHERE nombre ='{user.Nombre}';";
            DBConnection.ExecuteNonQuery(querySQL);
        }
        
    }
}