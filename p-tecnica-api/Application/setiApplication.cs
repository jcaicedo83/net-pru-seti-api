using Newtonsoft.Json;
using p_tecnica_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Xml;

namespace p_tecnica_api.Application
{
    public class setiApplication
    {
        public ResponseDto enviarPedido(RequestDto _request)
        {
            string _json = JsonConvert.SerializeObject(_request);
            XmlDocument doc = JsonConvert.DeserializeXmlNode(_json);


            HttpClient cliente = new HttpClient();
            var content = cliente.GetAsync("https://run.mocky.io/v3/19217075-6d4e-4818-98bc-416d1feb7b84");

            var result = content.Result.Content.ReadAsStringAsync().Result;

            ///convertir el string resultante en xml
            ///

            doc.LoadXml(result);
            string jsonText = JsonConvert.SerializeXmlNode(doc);

            ResponseDto response = JsonConvert.DeserializeObject<ResponseDto>(jsonText);

            return response;

        }
    }
}