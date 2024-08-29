### ApiServer plugin structure

- Database > PluginTemplateContext: Define your DbSets (tables) here
- Database > Entities: Put your database entity classes here
- Database > Migrations: The migrations you will create should be put in here
- Helpers: Put smaller often used helper function in classes in here
- Http > Controllers: Put your http controllers in here, try to replicate the path in the folder structure, e.g. /admin/mycoolfeature/owo => Http/Controllers/Admin/Mycoolfeature/OwoController.cs
- Http > Middleware: Use this directory to store all your middlewares
- Implementations: Your plugin interface implementations should be stored in this directory
- Models: Store your models in here
- Services: Put your own services in here