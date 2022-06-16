using AwesomeNetworkM35.Models.Users;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNetworkM35.Data.Repository
{
    public class FriendsRepository : Repository<Friend>
    {
        public FriendsRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void AddFriend(User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends == null)
            {
                var item = new Friend()
                {
                    UserId = target.Id,
                    User = target,
                    CurrentFriend = Friend,
                    CurrentFriendId = Friend.Id,
                };

                Create(item);
            }
        }

        public List<User> GetFriendsByUser(User target)
        {
            var friends = Set.Include(x => x.CurrentFriend).AsEnumerable().Where(x => x.User.Id == target.Id).Select(x => x.CurrentFriend);

            //костыль, чтобы записался друг сам себе
            if (friends == null)
            {
                AddFriend(target, target);
                GetFriendsByUser(target);
            }

            return friends.ToList();
        }

        public void DeleteFriend(User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends != null)
            {
                Delete(friends);
            }
        }

    }
}
