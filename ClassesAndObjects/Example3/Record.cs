namespace Example3
{
    public class Record
    {
        public string OwnerName { get; set; }
        public int OwnerID { get; set; }
        public bool IsActive { get; set; }

        public string GetFormattedString()
        {
            string idText = "[" + this.OwnerID + "]";
            string isActiveText = IsActive ? "(active)" : "(inactive)";
            return idText + " " + this.OwnerName + " " + isActiveText;
        }
    }
}