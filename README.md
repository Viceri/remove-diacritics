# remove-diacritics
Método de extensão para remover diacrítica.
### Instalação

    Install-Package Viceri.RemoveDiacritics 

### Como usar

    [InlineData("Ý", "Y")]
    public void Should_Remove_Diacritics(string text, string expected)
    {
        Assert.Equal(expected, text.RemoveDiacritics());
    }
