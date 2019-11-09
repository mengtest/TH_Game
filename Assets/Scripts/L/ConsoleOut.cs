﻿using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace L
{
    public class ConsoleOut : TextWriter
    {
        public ConsoleOut()
        {
            Encoding = Encoding.UTF8;
        }

        public override Encoding Encoding { get; }

        public override void Write(string value)
        {
            Debug.Log(value);
        }

        public override void WriteLine(string value)
        {
            Debug.Log(value);
        }

        public static void Init()
        {
            Console.SetOut(new ConsoleOut());
        }

        public static void Log(string value)
        {
            Console.WriteLine(value);
        }
    }
}