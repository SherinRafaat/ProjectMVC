namespace ProjectMVC.Repository
{
	public interface ICompany
	{
       public List<Job> GetAll();//string includes=null)

        public Company GetById(int id);

        void Insert(Company  obj);

        void Update(Company  obj);

        void Delete(int id);

		
	}
}
