using Xunit;
using CpfValidatorService.Core.Services;

namespace CpfValidatorService.Tests
{
    public class CpfValidationServiceTests
    {
        [Fact]
        public void ValidCpf_ReturnsTrue()
        {
            var service = new CpfValidationService();
            string validCpf = "123.456.789-09"; // substitua por um CPF válido
            bool result = service.IsValid(validCpf);
            Assert.True(result);
        }

        [Fact]
        public void InvalidCpf_ReturnsFalse()
        {
            var service = new CpfValidationService();
            string invalidCpf = "111.111.111-11";
            bool result = service.IsValid(invalidCpf);
            Assert.False(result);
        }
    }
}
