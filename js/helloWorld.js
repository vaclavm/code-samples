export function helloWorld()
{
    // start::print-hello-world
    const helloWorld = createHelloWorld();

    console.log(helloWorld); // helloWorld contains "Hello World!"
    // end::print-hello-world
}

// start::create-hello-world
function createHelloWorld()
{
    const hello = "Hello";
    const world = "World";

    return `${hello} ${world}!`;
}
// end::create-hello-world