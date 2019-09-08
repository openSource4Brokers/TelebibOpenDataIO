using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebibOpenDataIO
{
    class MdbDataTb2
    {
        public void DataOrgTbInsert(string mdbLocation, string sqlQualifyingTb2, string sqlValeurTb2, string cnnSQL)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(cnnSQL))
            {
                try
                {
                    OleDbConnection cnnMdb = new OleDbConnection
                    {
                        ConnectionString = mdbLocation
                    };
                    cnnMdb.Open();

                    OleDbCommand cmdQualifying = new OleDbCommand
                    {
                        Connection = cnnMdb,
                        CommandText = sqlQualifyingTb2
                    };

                    OleDbCommand cmdValeur = new OleDbCommand
                    {
                        Connection = cnnMdb,
                        CommandText = sqlValeurTb2
                    };

                    OleDbDataReader readerQualifyingTb2 = cmdQualifying.ExecuteReader();
                    OleDbDataReader readerValeurTb2 = cmdValeur.ExecuteReader();

                    List<TbQualifier> qualifyingTb2New = new List<TbQualifier>();
                    List<TbValeur> valeurTb2New = new List<TbValeur>();

                    while (readerQualifyingTb2.Read())
                    {
                        //DateTime datCre;
                        //DateTime datMod;
                        //DateTime datDel;
                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datcre"]))
                        //{
                        //    datCre = (DateTime)readerQualifyingTb2["Datcre"];
                        //}

                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datmod"]))
                        //{
                        //    datMod = (DateTime)readerQualifyingTb2["Datmod"];
                        //}

                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datdel"]))
                        //{
                        //    datDel = (DateTime)readerQualifyingTb2["Datdel"];
                        //}

                        qualifyingTb2New.Add(new TbQualifier
                        {
                            DE = readerQualifyingTb2["DE"].ToString().Trim(' '),
                            Qualifier = readerQualifyingTb2["Qualifiant"].ToString().Trim(' '),
                            Lbc1 = readerQualifyingTb2["Lbc-1"].ToString().Trim(' '),
                            Lbc2 = readerQualifyingTb2["Lbc-2"].ToString().Trim(' '),
                            Lbc3 = readerQualifyingTb2["Lbc-3"].ToString().Trim(' '),
                            Lbc4 = readerQualifyingTb2["Lbc-4"].ToString().Trim(' '),

                            // Datcre = DateTime.Now
                            // Datmod = datMod,
                            // Datdel = datDel
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        _ = connection.Execute("spTb2Qualifiers_InsertFull @DE, @Qualifier, @Version, @Lbc1, @Lbc2, @Lbc3, @Lbc4", qualifyingTb2New);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerQualifyingTb2.Close();

                    while (readerValeurTb2.Read())
                    {
                        //DateTime datCre;
                        //DateTime datMod;
                        //DateTime datDel;
                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datcre"]))
                        //{
                        //    datCre = (DateTime)readerQualifyingTb2["Datcre"];
                        //}

                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datmod"]))
                        //{
                        //    datMod = (DateTime)readerQualifyingTb2["Datmod"];
                        //}

                        //if (!Convert.IsDBNull(readerQualifyingTb2["Datdel"]))
                        //{
                        //    datDel = (DateTime)readerQualifyingTb2["Datdel"];
                        //}

                        valeurTb2New.Add(new TbValeur
                        {
                            Code = readerValeurTb2["Code"].ToString().Trim(' '),
                            Valeur = readerValeurTb2["Valeur"].ToString().Trim(' '),
                            Lbc1 = readerValeurTb2["Lbc-1"].ToString().Trim(' '),
                            Lbc2 = readerValeurTb2["Lbc-2"].ToString().Trim(' '),
                            Lbl1 = readerValeurTb2["Lbl-1"].ToString().Trim(' '),
                            Lbl2 = readerValeurTb2["Lbl-2"].ToString().Trim(' '),
                            Lbl3 = readerValeurTb2["Lbl-3"].ToString().Trim(' '),
                            Lbl4 = readerValeurTb2["Lbl-4"].ToString().Trim(' ')

                            // Datcre = DateTime.Now
                            // Datmod = datMod,
                            // Datdel = datDel
                        });
                    }

                    try
                    {
                        // connection.Execute("dbo.spVsoftCustomers_InsertFull @Id, @A107, @A108, @A100", customers);                    
                        _ = connection.Execute("spTb2Valeurs_InsertFull @Code, @Valeur, @Lbc1, @Lbc2, @Lbl1, @Lbl2, @Lbl3, @Lbl4", valeurTb2New);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    readerValeurTb2.Close();
                    cnnMdb.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
