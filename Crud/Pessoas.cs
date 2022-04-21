using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Crud
{
    class Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        
        public void GetPessoa(int Id)
        {
            var sql = "SELECT * FROM pessoas WHERE Id = " + Id;

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using(var cmd = new MySqlCommand(sql, cn))
                    {
                        using(var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    this.Id = Convert.ToInt32(dr["Id"]);
                                    this.Nome = dr["Nome"].ToString();
                                    this.Telefone = dr["Telefone"].ToString();
                                }
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        public void AlteraPessoa()
        {
            var sql = "";

            if (this.Id == 0)
            {
                sql = "INSERT INTO pessoas (Nome, Telefone) VALUES (@Nome, @Telefone)";
            }
            else
            {
                sql = "UPDATE pessoas SET Nome=@Nome, Telefone=@Telefone WHERE Id=" + this.Id;
            }

            try
            {
                using(var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Telefone", this.Telefone);

                        cmd.ExecuteNonQuery();

                        cn.Close();

                        MessageBox.Show("Concluído");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ExcluiPessoa()
        {
            string sql = "DELETE FROM pessoas WHERE Nome = @Nome";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.CommandType = CommandType.Text;


                        cmd.ExecuteNonQuery();

                        cn.Close();

                        MessageBox.Show("Excluído!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // Retorna Select * From no Grid
        public static DataTable GetPessoas(bool pessoas)
        {
            var dt = new DataTable();

            var sql = "SELECT Id, Nome, Telefone FROM teste_cadastros.pessoas";

            try
            {
                using(var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using(var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        
    }
}
