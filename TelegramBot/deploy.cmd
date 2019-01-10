dotnet publish
docker build -t bot-on-heroku .\bin\Debug\netcoreapp2.2\publish\
docker tag bot-on-heroku registry.heroku.com/removethisapplater/web
docker push registry.heroku.com/removethisapplater/web
heroku container:release web -a removethisapplater