using Cellula.Entity;
using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Proletarians.Interfaces;
using Cellula.Dtos.HeroesDtos.Marvel;

namespace ComicsTests
{
    public class UnitTest1
    {

        private ComicsForGeeksContext context;
        private readonly IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto> _heroRequestBase;
        public UnitTest1(IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto> heroRequestBase)
        {
            context = TestHelper.CreateDbContext<ComicsForGeeksContext>();
            _heroRequestBase = heroRequestBase;
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
                await context.SaveChangesAsync();
                Assert.IsType<GenderEntity>(result);
            }
            catch (Exception ex)
            {


            }

        }
        [Fact]
        public async Task Test()
        {
            var result = _heroRequestBase.SearchHero("spi");
            Assert.Null(result);
        }


    }
}
