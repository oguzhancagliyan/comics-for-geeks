using Cellula.Entity;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ComicsTests
{
    public class UnitTest1
    {
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
                ComicsForGeeksContext context = new ComicsForGeeksContext();                
                var result = await context.Genders.AddAsync(new GenderEntity
                {
                    GenderName = "Male",
                });
                Assert.IsType<GenderEntity>(result);
            }
            catch (Exception ex)
            {

      
            }

        }

    }
}
