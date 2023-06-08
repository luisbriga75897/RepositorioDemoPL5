using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using trabalhoLab.Classes;

namespace trabalhoLab.Classes
{
    public class AlteracoesFisicas
    {
        public TipoRegistoFisico TipoRegistoFisico { get; set; } // tipo do registo das alterações físicas - TipoRegistoFisico - TipoRegistoFisico(541,"Peso","Kg")
        public float Valor { get; set; } // valor do registo - flaot - 12.5
        public DateTime Data { get; set; }    // data do registo - "12-03-2006"

        public XElement ToXML()
        {
            XElement no = new XElement("alteracaoFisica");
            no.Add(new XAttribute("valor", Valor));
            no.Add(new XAttribute("data", Data.Date.ToShortDateString()));
            no.Add(TipoRegistoFisico.ToXML());

            return no;
        }

    }
}
