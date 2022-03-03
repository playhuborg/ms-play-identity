using Play.Identity.Entities;

namespace Play.Identity
{
    public static class Extensions
    {
        public static UserDto AsDto(this ApplicationUser user)
        {
            return new UserDto(
                user.Id,
                user.UserName,
                user.Email,
                user.CreatedOn,
                user.Cash
            );
        }
    }
}