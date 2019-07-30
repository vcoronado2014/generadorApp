using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace generadorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            string cadena = "BDColegioSql";
            StringBuilder sb = new StringBuilder();
            sb.Append("using System; \r\n");
            sb.Append("using System.Collections.Generic; \r\n");
            sb.Append("using System.Linq; \r\n");
            sb.Append("using System.Text; \r\n");
            sb.Append("using VCFramework.Negocio.Factory; \r\n");
            //saltos
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            //namespace
            sb.AppendFormat("namespace {0}", txtNombrePaquete.Text);
            sb.Append("\r\n");
            //abre llave
            sb.Append("{ \r\n");
            //clase
            sb.AppendFormat("public class {0}", txtNombreClase.Text);
            sb.Append("\r\n");
            //abre llave
            sb.Append("{ \r\n");
            //cadena de conexion
            sb.Append("public static System.Configuration.ConnectionStringSettings setCnsWebLun = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + '"' + cadena + '"' + "];");
            sb.Append("\r\n");
            //aca debieran ir todos los metodos
            if (chkListarTodo.Checked)
            {
                sb.Append(InsertarListarTodo());
                sb.Append("\r\n");
            }
            if (chkListarId.Checked)
            {
                sb.Append(ListarPorElemento());
                sb.Append("\r\n");
            }
            if (chkObtenerId.Checked)
            {
                sb.Append(InsertarPorId());
                sb.Append("\r\n");
            }
            if (chkInsert.Checked)
            {
                sb.Append(InsertarInsert());
                sb.Append("\r\n");
            }
            if (chkUpdate.Checked)
            {
                sb.Append(InsertarActualizar());
                sb.Append("\r\n");
            }
            if (chkDelete.Checked)
            {
                sb.Append(InsertarEliminar());
                sb.Append("\r\n");
            }



            //aca cerramos clase
            sb.Append("} \r\n");
            //aca cerramos namespace
            sb.Append("} \r\n");
            //mostramos
            txtResultado.Text = sb.ToString();

        }
        
        private string InsertarListarTodo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public static List<{0}.{1}> Listar{1}()", txtNombrePaquete.Text, txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("{ \r\n");
            sb.Append("VCFramework.Negocio.Factory.Factory fac = new VCFramework.Negocio.Factory.Factory();");
            sb.Append("\r\n");
            sb.AppendFormat("List<object> lista = fac.Leer<VCFramework.Entidad.{0}>(setCnsWebLun);", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.AppendFormat("List<VCFramework.Entidad.{0}> lista2 = new List<VCFramework.Entidad.{0}>();", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("if (lista != null)");
            sb.Append("\r\n");
            sb.Append("{ \r\n");
            sb.AppendFormat("lista2 = lista.Cast<VCFramework.Entidad.{0}>().ToList();", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("} \r\n");
            sb.Append("return lista2;");
            sb.Append("\r\n");
            sb.Append("} \r\n");

            //public static List<VCFramework.Entidad.Persona> ListarPersonas()
            //{
            //    VCFramework.Negocio.Factory.Factory fac = new VCFramework.Negocio.Factory.Factory();
            //    List<object> lista = fac.Leer<VCFramework.Entidad.Persona>(setCnsWebLun);
            //    List<VCFramework.Entidad.Persona> lista2 = new List<VCFramework.Entidad.Persona>();
            //    if (lista != null)
            //    {
            //        lista2 = lista.Cast<VCFramework.Entidad.Persona>().ToList();
            //    }
            //    return lista2;
            //}


            return sb.ToString();
        }

        private string InsertarPorId()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("public static VCFramework.Entidad.{0} Obtener{0}PorId(int id)", txtNombreClase.Text);
            sb.Append("{ \r\n");
            sb.AppendFormat("    VCFramework.Entidad.{0} retorno = new VCFramework.Entidad.{0}();", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("    VCFramework.Negocio.Factory.Factory fac = new VCFramework.Negocio.Factory.Factory();");
            sb.Append("\r\n");
            sb.Append("FiltroGenerico filtro = new FiltroGenerico();");
            sb.Append("\r\n");
            sb.Append("filtro.Campo = " + '"' + "ID" + '"');
            sb.Append("\r\n");
            sb.Append("filtro.Valor = id.ToString();");
            sb.Append("\r\n");
            sb.Append("    filtro.TipoDato = TipoDatoGeneral.Entero;");
            sb.Append("\r\n");
            sb.AppendFormat("List<VCFramework.Entidad.{0}> lista2 = new List<VCFramework.Entidad.{0}>();", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.AppendFormat("    List<object> lista = fac.Leer<VCFramework.Entidad.{0}>(filtro, setCnsWebLun);", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("if (lista != null)");
            sb.Append("\r\n");
            sb.Append("{ \r\n");
            sb.AppendFormat("lista2 = lista.Cast<VCFramework.Entidad.{0}>().ToList();", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("} \r\n");

            sb.Append("if (lista2 != null && lista2.Count == 1)");
            sb.Append("\r\n");
            sb.Append("retorno = lista2[0];");
            sb.Append("\r\n");
            sb.Append("return retorno;");
            sb.Append("\r\n");

            sb.Append("} \r\n");

            return sb.ToString();
        }

        private string InsertarInsert()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public static int Insertar(VCFramework.Entidad.{0} entidad)", txtNombreClase.Text);
            sb.Append("\r\n");
            //abre llave
            sb.Append("{ \r\n");
            sb.Append(" Factory fac = new Factory();");
            sb.Append("\r\n");
            sb.AppendFormat("return fac.Insertar<VCFramework.Entidad.{0}>(entidad, setCnsWebLun);", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("} \r\n");

            return sb.ToString();

        }
        private string InsertarEliminar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public static int Eliminar(VCFramework.Entidad.{0} entidad)", txtNombreClase.Text);
            sb.Append("\r\n");
            //abre llave
            sb.Append("{ \r\n");
            sb.Append(" Factory fac = new Factory();");
            sb.Append("\r\n");
            sb.AppendFormat("return fac.Delete<VCFramework.Entidad.{0}>(entidad, setCnsWebLun);", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("} \r\n");

            return sb.ToString();

        }
        private string InsertarActualizar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public static int Actualizar(VCFramework.Entidad.{0} entidad)", txtNombreClase.Text);
            sb.Append("\r\n");
            //abre llave
            sb.Append("{ \r\n");
            sb.Append(" Factory fac = new Factory();");
            sb.Append("\r\n");
            sb.AppendFormat("return fac.Update<VCFramework.Entidad.{0}>(entidad, setCnsWebLun);", txtNombreClase.Text);
            sb.Append("\r\n");
            sb.Append("} \r\n");

            return sb.ToString();

        }
        private string Abrir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \r\n");
            return sb.ToString();
        }
        private string Cerrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("} \r\n");
            return sb.ToString();
        }
        private string InsertarSalto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            return sb.ToString();
        }

        private string SepararCadena(string cadena)
        {
            //string[] split =  Regex.Split(str, @"(?<!^)(?=[A-Z])");
            string retorno = "";
            string[] split = Regex.Split(cadena, @"(?<!^)(?=[A-Z])");
            if (split.Length > 0)
            {
                string proc = "";
                for (int i=0; i< split.Length; i++)
                {
                    if (i == 0)
                        proc = split[i] + "_";
                    else
                        proc = proc + split[i];
                }
                retorno = proc;
            }

            return retorno;
        }
        private string ListarPorElemento()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public static List<VCFramework.Entidad.{0}> Listar{0}(int {1})", txtNombreClase.Text, txtIndicePost.Text);
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append(InsertarSalto());
            sb.Append("VCFramework.Negocio.Factory.Factory fac = new VCFramework.Negocio.Factory.Factory();");
            sb.Append(InsertarSalto());
            sb.AppendFormat("List<VCFramework.Entidad.{0}> lista2 = new List<VCFramework.Entidad.{0}>();", txtNombreClase.Text);
            sb.Append(InsertarSalto());
            sb.Append("//agregamos filtros");
            sb.Append(InsertarSalto());
            sb.Append("VCFramework.Negocio.Factory.FiltroGenerico filtro = new FiltroGenerico();");
            sb.Append(InsertarSalto());
            sb.Append("filtro.Campo = ");
            sb.Append('"');
            sb.AppendFormat("{0}", SepararCadena(txtIndicePost.Text).ToUpper());
            sb.Append('"');
            sb.Append(InsertarSalto());
            sb.Append("filtro.TipoDato = TipoDatoGeneral.Entero;");
            sb.Append(InsertarSalto());
            sb.AppendFormat("filtro.Valor = {0}.ToString();", txtIndicePost.Text);
            sb.Append(InsertarSalto());
            sb.AppendFormat("List<object> lista = fac.Leer<VCFramework.Entidad.{0}>(filtro, setCnsWebLun);", txtNombreClase.Text);
            sb.Append(InsertarSalto());
            sb.Append("if (lista != null)");
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.AppendFormat("lista2 = lista.Cast<VCFramework.Entidad.{0}>().ToList();", txtNombreClase.Text);
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append("if (lista2 != null && lista2.Count > 0) {");
            sb.Append(InsertarSalto());
            sb.Append("lista2 = lista2.FindAll(p => p.Eliminado == 0).ToList(); }");
            sb.Append(InsertarSalto());
            sb.Append("return lista2;");
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());

            return sb.ToString();
        }
        private string EncabezadoControlador()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Collections.Generic;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Linq;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Net;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Net.Http;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Web.Http;");
            sb.Append(InsertarSalto());
            sb.Append("using VCFramework.Entidad;");
            sb.Append(InsertarSalto());
            sb.Append("using VCFramework.NegocioMySQL;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Web.Http.Cors;");
            sb.Append(InsertarSalto());
            sb.Append("using Newtonsoft.Json;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Xml;");
            sb.Append(InsertarSalto());
            sb.Append("using System.Net.Http.Formatting;");
            sb.Append(InsertarSalto());
            sb.Append("using Newtonsoft.Json.Linq;");
            sb.Append(InsertarSalto());

            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            StringBuilder sb = new StringBuilder();
            sb.Append(EncabezadoControlador());
            //aca namespace webapi
            sb.AppendFormat("namespace {0}.Controllers", txtNombreWebApi.Text);
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            //la clase
            //    [EnableCors(origins: "*", headers: "*", methods: "*")]
            //public class InstitucionController : ApiController
            sb.Append("[EnableCors(origins: ");
            sb.Append('"');
            sb.Append("*");
            sb.Append('"');
            sb.Append(", headers: ");
            sb.Append('"');
            sb.Append("*");
            sb.Append('"');
            sb.Append(", methods: ");
            sb.Append('"');
            sb.Append("*");
            sb.Append('"');
            sb.Append("]");
            sb.Append(InsertarSalto());
            sb.AppendFormat("public class {0}Controller : ApiController", txtNombreClase.Text);
            sb.Append(InsertarSalto());
            //abrimos clase

            sb.Append(Abrir());
            //metodo options por defecto
            #region options
            sb.Append("[AcceptVerbs(");
            sb.Append('"');
            sb.Append("OPTIONS");
            sb.Append('"');
            sb.Append("]");
            sb.Append(InsertarSalto());
            sb.Append("public void Options()");
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            #endregion

            //ahora los metodos
            if (chkPost.Checked)
            {
                sb.Append(GenerarPost());
            }
            if (chkGet.Checked)
            {
                sb.Append(GenerarGet());
            }

            //cerramos clase
            sb.Append(Cerrar());
            //ahora cerramos
            sb.Append(Cerrar());

            txtResultado.Text = sb.ToString();

        }
        private string GenerarPost()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[AcceptVerbs(");
            sb.Append('"');
            sb.Append("POST");
            sb.Append('"');
            sb.Append("]");
            sb.Append(InsertarSalto());
            sb.Append("public void Post()");
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append(InsertarSalto());
            sb.Append("string Input = JsonConvert.SerializeObject(DynamicClass);");
            sb.Append(InsertarSalto());
            sb.Append("dynamic data = JObject.Parse(Input);");
            sb.Append(InsertarSalto());
            string idBusqueda = "id";
            if (txtIndicePost.Text != "" || txtIndicePost.Text != "id")
            {
                idBusqueda = txtIndicePost.Text;
            }
            string idBusquedaT = idBusqueda.ToUpperInvariant();
            sb.AppendFormat("string {0}str = ", idBusqueda.ToLower());
            sb.Append('"');
            sb.Append('"');
            sb.Append(";");
            sb.Append(InsertarSalto());
            sb.Append("//validaciones antes de ejecutar la llamada.");
            sb.Append(InsertarSalto());
            sb.AppendFormat("if (data.{0} != null)", txtIndicePost.Text);
            sb.Append(InsertarSalto());
            sb.AppendFormat("{0}str = data.{1};", idBusqueda.ToLower(), txtIndicePost.Text);
            sb.Append(InsertarSalto());
            sb.Append("HttpResponseMessage httpResponse = new HttpResponseMessage();");
            sb.Append(InsertarSalto());
            sb.Append("try");
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.AppendFormat("if ({0}str != string.Empty)", idBusqueda.ToLower());
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.AppendFormat("VCFramework.Entidad.{0} {1}s = VCFramework.Negocio.{0}.Listar{0}(int.Parse({2}str));", txtNombreClase.Text, txtNombreClase.Text.ToLower(), idBusqueda.ToLower());
            sb.Append(InsertarSalto());
            sb.AppendFormat("if ({0}s != null && {0}s.Count > 0)", txtNombreClase.Text.ToLower());
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append("httpResponse = new HttpResponseMessage(HttpStatusCode.OK);");
            sb.Append(InsertarSalto());
            sb.AppendFormat("String JSON = JsonConvert.SerializeObject({0}s);", txtNombreClase.Text.ToLower());
            sb.Append(InsertarSalto());
            sb.Append(" httpResponse.Content = new StringContent(JSON);");
            sb.Append(InsertarSalto());
            sb.Append("httpResponse.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(VCFramework.Negocio.Utiles.JSON_DOCTYPE);");
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append("else {");
            sb.Append(InsertarSalto());
            sb.Append("httpResponse = new HttpResponseMessage(HttpStatusCode.NoContent);");
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append("catch (Exception ex) {");
            sb.Append("httpResponse = new HttpResponseMessage(HttpStatusCode.ExpectationFailed);");
            sb.Append("throw ex; }");
            sb.Append(InsertarSalto());
            sb.Append("return httpResponse;");
            sb.Append(InsertarSalto());
            sb.Append(InsertarSalto());
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());


            return sb.ToString();
        }

        private string GenerarGet()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[AcceptVerbs(");
            sb.Append('"');
            sb.Append("GET");
            sb.Append('"');
            sb.Append("]");
            sb.Append(InsertarSalto());
            sb.Append("public HttpResponseMessage Get([FromUri]string id)");
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append(InsertarSalto());
            sb.Append("//validaciones antes de ejecutar la llamada. \r\n");
            sb.Append("if (id == string.Empty)");
            sb.Append(InsertarSalto());
            sb.Append("throw new ArgumentNullException(");
            sb.Append('"');
            sb.Append("Id");
            sb.Append('"');
            sb.Append(");");
            sb.Append(InsertarSalto());
            sb.Append("HttpResponseMessage httpResponse = new HttpResponseMessage();");
            sb.Append(InsertarSalto());
            sb.Append("try \r\n {");
            sb.Append("int idBuscar = int.Parse(id);");
            sb.Append(InsertarSalto());
            sb.AppendFormat("VCFramework.Entidad.{0} {1} = VCFramework.Negocio.{0}.Obtener{0}PorId(idBuscar);", txtNombreClase.Text, txtNombreClase.Text.ToLower());
            sb.Append(InsertarSalto());
            sb.AppendFormat("if ({0} != null)", txtNombreClase.Text.ToLower());
            sb.Append(InsertarSalto());
            sb.Append(Abrir());
            sb.Append(InsertarSalto());
            sb.Append("httpResponse = new HttpResponseMessage(HttpStatusCode.OK);");
            sb.Append(InsertarSalto());
            sb.AppendFormat("String JSON = JsonConvert.SerializeObject({0});", txtNombreClase.Text.ToLower());
            sb.Append(InsertarSalto());
            sb.Append("httpResponse.Content = new StringContent(JSON); \r\n httpResponse.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(VCFramework.NegocioMySQL.Utiles.JSON_DOCTYPE); \r\n");
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append("else \r\n { \r\n httpResponse = new HttpResponseMessage(HttpStatusCode.NoContent); \r\n } \r\n");
            sb.Append(Cerrar());
            sb.Append(InsertarSalto());
            sb.Append("catch (Exception ex) \r\n { \r\n httpResponse = new HttpResponseMessage(HttpStatusCode.ExpectationFailed); \r\n throw ex; \r\n } \r\n return httpResponse; \r\n } \r\n");

            return sb.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
