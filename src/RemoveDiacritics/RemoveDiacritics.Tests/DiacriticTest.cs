using Xunit;

namespace Viceri.RemoveDiacritics.Tests
{
    public class DiacriticTest
    {

        [Theory]
        [InlineData("á", "a")]
        [InlineData("à", "a")]
        [InlineData("ã", "a")]
        [InlineData("â", "a")]
        [InlineData("ä", "a")]
        [InlineData("Á", "A")]
        [InlineData("À", "A")]
        [InlineData("Ã", "A")]
        [InlineData("Â", "A")]
        [InlineData("Ä", "A")]
        [InlineData("é", "e")]
        [InlineData("è", "e")]
        [InlineData("ê", "e")]
        [InlineData("ë", "e")]
        [InlineData("É", "E")]
        [InlineData("È", "E")]
        [InlineData("Ê", "E")]
        [InlineData("Ë", "E")]
        [InlineData("í", "i")]
        [InlineData("ì", "i")]
        [InlineData("î", "i")]
        [InlineData("ï", "i")]
        [InlineData("Í", "I")]
        [InlineData("Ì", "I")]
        [InlineData("Î", "I")]
        [InlineData("Ï", "I")]
        [InlineData("ó", "o")]
        [InlineData("ò", "o")]
        [InlineData("ô", "o")]
        [InlineData("õ", "o")]
        [InlineData("ö", "o")]
        [InlineData("Ó", "O")]
        [InlineData("Ò", "O")]
        [InlineData("Ô", "O")]
        [InlineData("Õ", "O")]
        [InlineData("Ö", "O")]
        [InlineData("ú", "u")]
        [InlineData("ù", "u")]
        [InlineData("û", "u")]
        [InlineData("ü", "u")]
        [InlineData("Ú", "U")]
        [InlineData("Ù", "U")]
        [InlineData("Û", "U")]
        [InlineData("Ü", "U")]
        [InlineData("ç", "c")]
        [InlineData("Ç", "C")]
        [InlineData("ñ", "n")]
        [InlineData("Ñ", "N")]
        [InlineData("ÿ", "y")]
        [InlineData("ý", "y")]
        [InlineData("Ý", "Y")]
        public void Should_Remove_Diacritics(string text, string expected)
        {
            Assert.Equal(expected, text.RemoveDiacritics());
        }
    }
}
