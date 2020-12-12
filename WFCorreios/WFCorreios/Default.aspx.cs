using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WFCorreios
{
    using WsCorreios;
    public partial class _Default : Page
    {

        private SiteMaster myMasterPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            myMasterPage = (SiteMaster)Page.Master;


        }
                     
        protected void btnConsultaCep(object sender, EventArgs e)
        {

            using (var ws = new AtendeClienteClient())
            {
                string cep = txtCep.Text;
                if(cep.Length == 8 && cep != "")
                {
                    var retorno = ws.consultaCEP(cep);
                    if(retorno == null)
                    {
                      myMasterPage.message("CEP Inválido!", SiteMaster.Alert_CSS.warning);
                    }
                    else
                    {
                        myMasterPage.message("CEP Encontrado!", SiteMaster.Alert_CSS.sucess);
                        txtStreet.Text = retorno.end;
                        txtCity.Text = retorno.cidade;                
                        
                    }
                    
                }
                else {
                    myMasterPage.message("CEP Inválido!", SiteMaster.Alert_CSS.warning);
                }



               



            }

            //string cep = txtCep.Text;

            //if (cep != "")
            //{
            //    ConsultaCep(txtCep.Text);
            //}
      
        }


        

    }
}