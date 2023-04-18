namespace Esercizio_MVC_Core_DB.Models.DB
{
	public static class DataBase
	{

		public static List<Staff> GetList()
		{
			using (var ctx = new AcademyNetContext())
			{
				return ctx.Staffs.ToList();
			}	
		}
		public static void AddPerson(Staff s)
		{
			using (var ctx = new AcademyNetContext())
			{
				ctx.Staffs.Add(s);
				ctx.SaveChanges();
			}
		}

		public static Staff GetPerson(int id)
		{
			using (var ctx = new AcademyNetContext())
			{
				return ctx.Staffs.FirstOrDefault(p => p.StaffId == id)!;
			}	
		}

		public static void Modify(Staff s)
		{
			using (var ctx = new AcademyNetContext())
            {
				var impiegato = ctx.Staffs.FirstOrDefault(i => i.StaffId == s.StaffId);
				impiegato.FirstName = s.FirstName;
				impiegato.LastName = s.LastName;
				impiegato.Email = s.Email;
				impiegato.StoreId = s.StoreId;
				ctx.SaveChanges();
			}
		}


		public static void Delete(Staff s)
		{
			using (var ctx = new AcademyNetContext())
			{
				var impiegato = ctx.Staffs.FirstOrDefault(i => i.StaffId == s.StaffId);
				ctx.Remove<Staff>(impiegato);
				ctx.SaveChanges();
			}
		}
	}
}


