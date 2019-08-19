using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "");

		void Insert(TEntity entity);

		void Update(TEntity entityToUpdate);

		void Remove(TEntity entityToDelete);
	}
}
