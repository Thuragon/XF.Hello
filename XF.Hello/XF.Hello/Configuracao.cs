using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Configuracao
    {
        public bool RastrearLocalização { get; set; }

        public bool PermitirCookie { get; set; }
        public bool DisponibilizarMural { get; set; }
        public bool EnviarEmail { get; set; }
        public bool ReceberSms { get; set; }
    }
}
