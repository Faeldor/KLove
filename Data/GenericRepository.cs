using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		public DbContext Context { get; }

		internal DbSet<TEntity> dbSet;

		public GenericRepository(KLoveContext context)
		{
			Context = context;
			dbSet = Context.Set<TEntity>();
		}

		public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "")
		{
			IQueryable<TEntity> query = dbSet;

			foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(includeProperty.Trim());
			}

			if (filter != null)
			{
				query = query.Where(filter);
			}

			return query;
		}

		//Adds Entity to Context and SavesChanges
		public virtual void Insert(TEntity entity)
		{
			var trackedState = dbSet.Add(entity);

			Context.SaveChanges();
		}

		//Updates the Entity in the Context and SavesChanges
		public virtual void Update(TEntity entityToUpdate)
		{
			var trackedState = dbSet.Update(entityToUpdate);

			Context.SaveChanges();
		}

		//Deletes the Entity from the Context and SavesChanges
		public virtual void Remove(TEntity entityToDelete)
		{
			var trackedState = dbSet.Remove(entityToDelete);

			Context.SaveChanges();
		}
	}
}
