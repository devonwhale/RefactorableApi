# RefactorableApi
A small .NET Core API designed to be bad enough to make you want to refactor it.

## Assumptions you can make

- Anything (class, method, whatever) starting with `Spoof` is there instead of something that would require more setup (database, external Api, ect.). You can assume it works as intended.
- A basket will always exist for a user. They do not need to create one (and cannot, but that is neither here nor there).
- There is a level of abstraction between this code and the front end. This takes an identifyer and gathers the complete object to pass into this application (so for example, this level would be what gets the `Item` object from the id to pass into the application)
