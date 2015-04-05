using System;

namespace ValidationConcept.Logger
{
    public class LoggerItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Comments { get; set; }

        public string TableName { get; set; }

        public string Field { get; set; }

        public int RowId { get; set; }

        public string Prop1 { get; set; }

        public string Prop2 { get; set; }
        
        public string PropX { get; set; }
        
        public string PropY { get; set; }

        public void Print()
        {
            Console.WriteLine("Name={0}; TableName={1}; Field={2}; RowId={3}; Prop1={4}; Prop2={5}; PropX={6}; PropY={7};",
                Name, TableName, Field, RowId, Prop1, Prop2, PropX, PropY);
        }
    }
}
