using SQLite;


namespace projectmain.Models
{
    [Table("activitytoday")]
    public class activity 
    {
        [PrimaryKey,Unique]
        public string Interval { get; set; }
       
        /// <summary>
        /// incommplete
        /// </summary>
       
        public string Name { get; set; }

        /// <summary>
        /// incommplete
        /// </summary>
        
        public string Category { get; set; }

        public int Categoryno { get; set; }

    }
}
