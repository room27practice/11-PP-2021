using System;

namespace Inheritance.Model
{
    public abstract class BaseParent
    {
        private bool isDeleted = false;

        protected BaseParent(int id)
        {
            Id = id;
            CreateDate = DateTime.UtcNow;
            IsDeleted = false;
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set
            {
                if (isDeleted) { return; }
                if (!isDeleted && value) { isDeleted = true; }
            }
        }

        #region Metod&PrivateSetter
        // public bool IsDeleted { get; private set; }
        //public void Delete()
        //{
        //    IsDeleted = true;
        //}
        #endregion

        public void GiveBaseInfo()
        {
            Console.WriteLine($"My Id is {Id}");
            Console.WriteLine($"I am created on {CreateDate.ToString("F")}");
        }

    }

    public class Diubel : BaseParent
    {
        public Diubel(int id, double length) : base(id)
        {
            Length = length;
        }

        public double Length { get; set; }
    }

    public class Tuhla : BaseParent
    {
        public Tuhla(int id, TuhlaSize size, Materials material, double bearingCappacity) : base(id)
        {
            Size = size;
            Material = material;
            BearingCappacity = bearingCappacity;
        }

        public TuhlaSize Size { get; set; }
        public Materials Material { get; set; }
        public double BearingCappacity { get; set; }
    }

    public enum TuhlaSize
    {
        chetvorka, edinichka,
    }

    public enum Materials
    {
        metal, chugun, durvo, keramic, clay, ytong
    }

}
