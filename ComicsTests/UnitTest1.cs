using Cellula.Entity;
using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
namespace ComicsTests
{
    public class UnitTest1
    {

        private ComicsForGeeksContext context;
        public UnitTest1()
        {
            context = TestHelper.CreateDbContext<ComicsForGeeksContext>();
        }
        [Fact]
        public void Test1()
        {

        }
        //[Fact]
        //public void CreateUserInPostgre()
        //{
        //    ComicsForGeeksContext context = new ComicsForGeeksContext();
        //    context.Users.Add(new UserEntity
        //    {
        //        EMail  = $"oguzhancaglayan127@gmail.com",

        //    })
        //}
        [Fact]
        public async Task AddGender_WhenGivingValidValue_ShouldReturnInstanceOfUserEntity()
        {
            try
            {
                var result = await context.Genders.AddAsync(new GenderEntity
                {
                    GenderName = "FMale",
                });
               await  context.SaveChangesAsync();
                Assert.IsType<GenderEntity>(result);
            }
            catch (Exception ex)
            {


            }

        }

    }
}
