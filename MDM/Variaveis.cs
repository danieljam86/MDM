﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDM
{
    public class Variaveis
    {
        
        private static string m_perfil = "";
        public static string Perfil
        {
            get { return m_perfil; }
            set { m_perfil = value; }
        }
        private static string _login = "";
        public static string Login
        {
            get { return _login; }
            set { _login = value; }
        }
    }
}