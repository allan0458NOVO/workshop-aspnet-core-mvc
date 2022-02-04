using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Professor
    {
        public Professor(){}
        public int Id { get; set; }

        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

    }
}