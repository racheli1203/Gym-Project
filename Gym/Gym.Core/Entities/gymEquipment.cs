namespace Gym
{
    public class gymEquipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfInspection { get; set; }//תאריך בדיקה
        public string category { get; set; }
        public int frequencyOfTesting { get; set; }//תדירות בדיקות
        public DateTime expiryDate { get; set; }//תאריך תפוגה

    }
}
