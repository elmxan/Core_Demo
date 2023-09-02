using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogCervices
	{
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public void BlogAdd(Blog Blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog Blog)
		{
			throw new NotImplementedException();
		}

        public List<Blog> GetBlogListWithCategory()
        {
           return  _blogdal.GetListWithCategory();
        }

        public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}
		public List<Blog> GetBlogById(int id)
		{
			return _blogdal.GetListAll(x => x.BlogId ==id);
		}
		public List<Blog> GetList()
		{
			return _blogdal.GetListAll();
		}

		public List<Blog> GetLastThreeBlog()
		{
			return _blogdal.GetListAll().Take(3).ToList();
		}

		public void Remove(Blog Blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogByWriter(int id)
		{
			return _blogdal.GetListAll(x => x.WriterId == id);
		}
	}
	
}
