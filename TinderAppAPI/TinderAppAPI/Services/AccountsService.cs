using Data;
using Data.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace learning_platform_back.Services
{
    public interface IAccountsService
    {
        Task Register(RegisterDto model);
        Task Login(LoginDto model);
        Task Logout();
    }

    public class AccountsService : IAccountsService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly TinderDBContext _dbContext;

        public AccountsService(UserManager<User> userManager, SignInManager<User> signInManager, TinderDBContext dbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this._dbContext = dbContext;
        }

        public async Task Login(LoginDto model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
                throw new Exception("Invalid user login or password.");

            await signInManager.SignInAsync(user, true);
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        public async Task Register(RegisterDto model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model), "Registration data is required.");

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null)
                throw new Exception("Email already exists.");

            var newUser = new User
            {
                Email = model.Email,
                UserName = model.Email,
                BirthDay = model.BirthDay,
                Gender = model.Gender,
                InterestedIn = model.InterestedIn,
                LookingFor = model.LookingFor,
                SexualOrientation = model.SexualOrientation,
                Interests = await GetOrCreateInterests(model.Interests),
                ProfilePhotos = model.ProfilePhotos.Select(p => new ProfilePhoto { Path = p.Path }).ToList()
            };

            var result = await userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errorMessage = string.Join(" ", result.Errors.Select(e => e.Description));
                throw new Exception($"Failed to register user: {errorMessage}");
            }
        }

        // ДОДАНИЙ МЕТОД
        private async Task<List<Interest>> GetOrCreateInterests(List<InterestDto> interestDtos)
        {
            var interests = new List<Interest>();

            foreach (var dto in interestDtos)
            {
                var existingInterest = await _dbContext.Interests
                    .FirstOrDefaultAsync(i => i.Name == dto.Name);

                if (existingInterest != null)
                {
                    interests.Add(existingInterest);
                }
                else
                {
                    var newInterest = new Interest { Name = dto.Name };
                    _dbContext.Interests.Add(newInterest);
                    interests.Add(newInterest);
                }
            }

            // Зберігаємо нові інтереси в базу даних
            await _dbContext.SaveChangesAsync();

            return interests;
        }
    }
}
