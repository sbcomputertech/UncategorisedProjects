import './App.css';

function Poem(props) {
  var poem = <p className="App-poem-p">
          <br />&nbsp;
          <div className="App-poem">
            <h3>Here's a nice poem I found,<br />to embrace the <i>christmas/coding spirit</i></h3>&nbsp;  <br />
            <code>
              He's making a database,<br />
              He's sorting it twice,<br />
              SELECT * FROM `Children` WHERE `Behavior`="nice";<br />
              SQL Clause is coming to town,<br />
              SQL Clause is coming to town.
            </code>
          </div>
        </p>
  if (props.poem === "yes") {
    return poem;
  } else if (props.poem === "no") {
    return <h4>No poem today. <br /><i>Sorry!</i></h4>;
  } else {
    return <meta name="poemError" content={`Hmmm. It looks like component 'Poem' had an unknown value of '${props.poem}'. It should either be 'yes' or 'no'.`} />
  }
}

function App() {
  return (
    <div className="App">
      <meta name="ignoreThis" content="This is just a hacky fix for my test code" />
      <header className="App-header">
      <h1><u><a href="http://samuelbennett.co.uk/" className="App-link" target="_blank" rel="noreferrer">Sam Bennett</a>'s christmas list</u></h1>
        <p>
          <ol className="App-list">
            <li>USB Blu-Ray drive</li>
            <li>Logitech K400+ USB receiver (USB-C if possible)</li>
            <li>USB-C OTG adapter</li>
            <li>Minecraft block building light</li>
          </ol>
        </p>
        <Poem poem="yes" />
      </header>
    </div>
  );
}

export default App;
