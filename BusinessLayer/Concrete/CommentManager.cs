﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentServices
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment Comment)
		{
			_commentDal.Insert(Comment);	
		}

		public List<Comment> GetList(int id)
		{
			return _commentDal.GetListAll(x => x.BlogId == id);
		}

		
	}
}
