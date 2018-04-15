using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void InitFullIndex()
        {
            // add all existing records to Lucene search index
            LuceneSearch.AddUpdateLuceneIndex(SampleDataRepository.GetAll());
        }

        static void IndexNewData(int _id, string _name, string _desc)
        {
            var new_record = new SampleData { Id = _id, Name = _name, Description = _desc };
            // todo: add record to database...

            // add record to Lucene search index
            LuceneSearch.AddUpdateLuceneIndex(new_record);
        }
    }
}
