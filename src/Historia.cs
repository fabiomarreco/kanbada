using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace kanbada
{
    [Serializable]
    public class Sprint
    {
        public Sprint()
        {
            this.Historias = new Historia[]{};
        }
        public Historia[] Historias { get; set; }
    }

    [Serializable]
    public class Historia
    {
        public Historia()
        {
            this.Codigo = "H1";
            this.Disabled = false;
        }
        
        [XmlAttribute]
        public string Codigo { get; set; }

        [XmlAttribute]
        public string Nome { get; set; }

        Tarefa[] _tarefas;
        public Tarefa[] Tarefas 
        {
            get { return _tarefas; }
            set
            {
                foreach (var t in value)
                    t.Historia = this;

                _tarefas = value;
            }
        }

        [XmlAttribute]
        public bool Disabled { get; set; }

    }


    [Serializable]
    public class Tarefa
    {
        public Tarefa()
        {
            this.Nome = string.Empty;
            this.Estado = EstadoTarefa.Backlog;
            this.Quem = string.Empty;
            this.Verificador = string.Empty;
            this.HorasAlocadas = string.Empty;
            Desc = null;
        }

        [XmlAttribute]
        public string Nome { get; set; }

        [XmlAttribute]
        public EstadoTarefa Estado { get; set; }

        [XmlIgnore]
        public Historia Historia { get; set; }

        [XmlAttribute]
        public string Quem { get; set; }
        [XmlAttribute]
        public string Verificador { get; set; }
        [XmlAttribute]
        public string HorasAlocadas { get; set; }
        
        [XmlElement]
        public string Desc { get; set; }
    }


    public enum EstadoTarefa
    {
        Backlog,
        Doing, 
        ToVerify,
        Verifying,
        Done
    }
}
