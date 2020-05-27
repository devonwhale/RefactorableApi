# RefactorableApi
A small .NET Core API designed to be bad enough to make you want to refactor it.

## Assumptions you can make

- Anything (class, method, whatever) starting with `Spoof` is there instead of something that would require more setup (database, external Api, ect.). You can assume it works as intended.
- A basket will always exist for a user. They do not need to create one (and cannot, but that is neither here nor there).
- There is a level of abstraction between this code and the front end. This translates requests from the front end into specific objects (like `Item`).
