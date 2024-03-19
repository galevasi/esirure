public static void All(Repository<TestClass> implicitKeyRepository,
                       Repository<TestClass, String> typedKeyRepository = null,
                       ExplicitKeyRepository<TestClass> explicitKeyRepository = null)
{
    // Fetch all entities from the implicit-key repository
    var entitiesFromImplicit = implicitKeyRepository.GetAll();
    // Process or utilize entities...
    
    if (typedKeyRepository != null)
    {
        // Fetch all entities from the explicitly typed-key repository, if provided
        var entitiesFromTyped = typedKeyRepository.GetAll();
        // Process or utilize entities...
    }

    if (explicitKeyRepository != null)
    {
        // Fetch all entities from the explicit key repository, if provided
        var entitiesFromExplicit = explicitKeyRepository.GetAll();
        // Process or utilize entities...
    }

    // Further actions or processing can be added here...
}
