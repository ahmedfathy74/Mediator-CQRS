using Microsoft.EntityFrameworkCore;
using PostLand.Application.Contracts;
using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Persistence.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory)
        {
           List<Post> allposts = new List<Post>();
            allposts = includeCategory ? await _dbContext.Posts.Include(x => x.Category).ToListAsync() 
                : await _dbContext.Posts.ToListAsync();
            return allposts;
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool includeCategory)
        {
            Post? post = new Post();
            post = includeCategory ? await _dbContext.Posts.Include(x => x.Category)
                .FirstOrDefaultAsync(x =>x.Id ==id)
                : await GetByIdAsync(id);
            if (post is null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            return post;
        }
    }
}
