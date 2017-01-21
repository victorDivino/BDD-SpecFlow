# Behavior Driven Development (BDD) com SpecFlow

Um exemplo muito simples de BDD com SpecFlow

# Instalações

Via Package Manager Console do Visual Studio será necessário instalar:

>+ **SpecFlow**: Install-Package SpecFlow

>+ **NUnitTestAdapter**: Install-Package
NUnitTestAdapter

# Configurações
Para escrever os arquivos de funcionalidade, ou feature, em português é necessário modificar o arquivo de configuração **App.config**:

```` xml
<specFlow>
    <unitTestProvider name="NUnit" />
    <language feature="pt-BR" />
</specFlow>
````
