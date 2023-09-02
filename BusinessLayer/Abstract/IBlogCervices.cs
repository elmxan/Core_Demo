using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogCervices
	{
		void BlogAdd(Blog Blog);
		void Remove(Blog Blog);
		void BlogUpdate(Blog Blog);
		List<Blog> GetList();
		Blog GetById(int id);
		List<Blog>GetBlogListWithCategory();
		List<Blog>GetBlogByWriter(int id);	
	
	}
}
