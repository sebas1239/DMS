using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using DMS.Models;
using System.Security.Cryptography;
using System.Text;


namespace DMS.Account
{
    public partial class Register : Page
    {
        #region Variables
         private static string m_strClave = "Seb-bus-DMS";
        string cadena1 = string.Empty;
        string cadena = string.Empty;
        //string cadena = "dbBiometrico";

        // string cones = Encriptar(cadena1);
        //   string cone = DesEncriptar(cadena);
        AD.clsUser m_clsUsers = new AD.clsUser();
        #endregion
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Session["Email"] = Email.Text;
            Session["Nombre"] = Nombre.Text;
            Session["Cedula"] = Cedula.Text;
            Session["Direccion"] = Direccion.Text;
            Session["Telefono"] = Telefono.Text;
            Session["Password"] = Encriptar(Password.Text);

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);

           
            if (result.Succeeded)
            {
                m_clsUsers.GuardarCliente(Session["Nombre"].ToString(), Session["Email"].ToString(), Session["Cedula"].ToString(), Session["Direccion"].ToString(), Session["Telefono"].ToString());
                
                string code = manager.GenerateEmailConfirmationToken(user.Id);
                string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                manager.SendEmail(user.Id, "Confirmar cuenta", "Para confirmar la cuenta, haga clic <a href=\"" + callbackUrl + "\">aquí</a>.");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }

        /// <summary>
        /// Encripta una cadena 
        /// </summary>
        /// <param name="CadenaAEncriptar">Cadena que sera encriptada</param>
        /// <returns>Retorna la palabra encriptada</returns>
        public static string Encriptar(string CadenaAEncriptar)
        {
            if (CadenaAEncriptar != string.Empty)
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();

                DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(m_strClave));
                DES.Mode = CipherMode.ECB;

                ICryptoTransform DESEncrypt = DES.CreateEncryptor();
                byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(CadenaAEncriptar);

                return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            else
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// Desencripta una cadena 
        /// </summary>
        /// <param name="CadenaAEncriptar">Cadena que sera desencriptada</param>
        /// <returns>Retorna la palabra desencriptada</returns>
        public static string DesEncriptar(string CadenaAEncriptar)
        {
            string Desencriptada = string.Empty;
            if (CadenaAEncriptar != string.Empty)
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
                byte[] keyhash = null;
                keyhash = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(m_strClave));
                byte[] buff;


                hashMD5 = null;
                DES.Key = keyhash;
                DES.Mode = CipherMode.ECB;
                buff = Convert.FromBase64String(CadenaAEncriptar);
                Desencriptada = ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));
            }
            return Desencriptada;
        }
    }
}