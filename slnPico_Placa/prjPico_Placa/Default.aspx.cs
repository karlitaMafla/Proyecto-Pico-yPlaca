using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjPico_Placa
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            string placa = txtplaca.Text;
         
            DateTime fecha=DateTime.Now;
            Boolean isNum=false;


               if (placa.Length == 8) {
                   string letra = placa.Substring(0, 3);
                   string num= placa.Substring(4, 4);
                       foreach (char c in letra)
                       {
                           if (char.IsNumber(c) == true)
                           {
                               isNum = true;
                           }
                       }
                       foreach (char c in num)
                       {
                           if (char.IsNumber(c) == false)
                           {
                               isNum = true;
                           }
                       }

               if(isNum==false){
                         try{
                                  fecha = DateTime.Parse(txtfecha.Text);
                              } catch (Exception ex) {
                                  Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Fecha Ingresada no es valida,Intentar con otro como 02/04/2019');</script>");
                              }


                            int  DiaRegla = int.Parse(placa.Substring(7, 1));
                            TimeSpan ts = new TimeSpan(int.Parse(hora.Value), int.Parse(minutos.Value), 0);
                            fecha = fecha.Date + ts;

                            if ("Monday".Equals(fecha.DayOfWeek.ToString()))
                            {
                                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Es dia Lunes la Fecha Ingresada');</script>");
                                if (DiaRegla==1 || DiaRegla == 2)
                                {
                                    if (ts>= new TimeSpan(7,0, 0) && ts <= new TimeSpan(9, 30, 0) || ts >= new TimeSpan(16, 0, 0) && ts <= new TimeSpan(19, 30, 0)) {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo no puede trasnsitar!! esta en pico y placa');</script>");
                                    } else {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo puede transitar pero prestar atencion ya que le toca pico y placa de 07:00-09:00 y de 16:00-19:00');</script>");
                                    }
                                }
                                else
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Carro sin restricion para transitar');</script>");
                                }

                            }


                            if ("Tuesday".Equals(fecha.DayOfWeek.ToString()))
                            {
                                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Es dia Martes la Fecha Ingresada');</script>");
                                if (DiaRegla == 3 || DiaRegla == 4)
                                {
                                    if (ts >= new TimeSpan(7, 0, 0) && ts <= new TimeSpan(9, 30, 0) || ts >= new TimeSpan(16, 0, 0) && ts <= new TimeSpan(19, 30, 0))
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo no puede trasnsitar!! esta en pico y placa');</script>");
                                    }
                                    else
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo puede transitar pero prestar atencion ya que le toca pico y placa de 07:00-09:00 y de 16:00-19:00');</script>");
                                    }
                                }
                                else
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Carro sin restricion para transitar');</script>");
                                }
                            }


                            if ("Wednesday".Equals(fecha.DayOfWeek.ToString()))
                            {
                                // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Es dia Miercoles la Fecha Ingresada');</script>");
                                if (DiaRegla == 5 || DiaRegla == 6)
                                {
                                    if (ts >= new TimeSpan(7, 0, 0) && ts <= new TimeSpan(9, 30, 0) || ts >= new TimeSpan(16, 0, 0) && ts <= new TimeSpan(19, 30, 0))
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo no puede trasnsitar!! esta en pico y placa');</script>");
                                    }
                                    else
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo puede transitar pero prestar atencion ya que le toca pico y placa de 07:00-09:00 y de 16:00-19:00');</script>");
                                    }
                                }
                                else
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Carro sin restricion para transitar');</script>");
                                }
                            }


                            if ("Thursday".Equals(fecha.DayOfWeek.ToString()))
                            {
                                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Es dia Jueves la Fecha Ingresada');</script>");
                                if (DiaRegla == 7 || DiaRegla == 8)
                                {
                                    if (ts >= new TimeSpan(7, 0, 0) && ts <= new TimeSpan(9, 30, 0) || ts >= new TimeSpan(16, 0, 0) && ts <= new TimeSpan(19, 30, 0))
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo no puede trasnsitar!! esta en pico y placa');</script>");
                                    }
                                    else
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo puede transitar pero prestar atencion ya que le toca pico y placa de 07:00-09:00 y de 16:00-19:00');</script>");
                                    }
                                }
                                else
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Carro sin restricion para transitar');</script>");
                                }
                            }


                            if ("Friday".Equals(fecha.DayOfWeek.ToString()))
                            {
                                // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Es dia Viernes la Fecha Ingresada');</script>");
                                if (DiaRegla == 9 || DiaRegla == 0)
                                {
                                    if (ts >= new TimeSpan(7, 0, 0) && ts <= new TimeSpan(9, 30, 0) || ts >= new TimeSpan(16, 0, 0) && ts <= new TimeSpan(19, 30, 0))
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo no puede trasnsitar!! esta en pico y placa');</script>");
                                    }
                                    else
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('El vehiculo puede transitar pero prestar atencion ya que le toca pico y placa de 07:00-09:00 y de 16:00-19:00');</script>");
                                    }
                                }
                                else
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Carro sin restricion para transitar');</script>");
                                }
                            }


                            if ("Saturday".Equals(fecha.DayOfWeek.ToString()) || "Sunday".Equals(fecha.DayOfWeek.ToString()))
                            {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Pico y Placa no aplica el fin de semana vehiculo libre para transitar');</script>");
                            }

                    }else{
                      Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Placa de vehiculo Invalida formato  para placas abc-1234');</script>");
                    }

               } else {
               Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Placa de vehiculo Invalida demasiados caracteres!!!');</script>");
               }

        }
    }
}