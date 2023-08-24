using CapaDatos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class AdminisCasa : Conexion
    {
        public int abmAgregarCasa(string accion, Casa casa)
        {
            int filasAfectadas = 0;

            using (MySqlConnection connection = getConexion()) // Hereda el método de la clase base
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;

                    if (accion == "Agregar")
                    {
                        command.CommandText = "INSERT INTO Casa (Direccion, Precio, Disponible, FechaConstruccion) VALUES (@Direccion, @Precio, @Disponible, @FechaConstruccion)";
                        command.Parameters.AddWithValue("@Direccion", casa.Direccion);
                        command.Parameters.AddWithValue("@Precio", casa.Precio);
                        command.Parameters.AddWithValue("@Disponible", casa.Disponible);
                        command.Parameters.AddWithValue("@FechaConstruccion", casa.FechaConstruccion);
                    }

                    filasAfectadas = command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Manejo específico de excepciones de MySQL
                    Console.WriteLine("Error en MySQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones generales
                    Console.WriteLine("Error general: " + ex.Message);
                }
            }

            return filasAfectadas;
        }

        public List<Casa> ObtenerCasasDesdeBaseDeDatos()
        {
            List<Casa> casas = new List<Casa>();

            using (MySqlConnection connection = getConexion())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM inmobiliaria_itsc.casa;";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string direccion = !reader.IsDBNull(reader.GetOrdinal("Direccion")) ? reader.GetString("Direccion") : string.Empty;
                            decimal precio = reader.GetDecimal("Precio");
                            bool disponible = !reader.IsDBNull(reader.GetOrdinal("Disponible")) && reader.GetBoolean("Disponible");
                            DateTime fechaConstruccion = reader.GetDateTime("FechaConstruccion");

                            Casa casa = new Casa(direccion, precio, disponible, fechaConstruccion);
                            casas.Add(casa);
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error en traer Casas desde la DB: " + ex.Message);
                }

            }

            return casas;
        }

    }
}