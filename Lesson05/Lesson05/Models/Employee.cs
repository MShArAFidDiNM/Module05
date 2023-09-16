﻿using System;

namespace Lesson05.Models
{
    internal class Employee
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; }
        public DateTime Hiredate { get; set; }
        public decimal Sal { get; set; }
        public decimal? Comm { get; set; }
        public int Deptno { get; set; }
    }
}
