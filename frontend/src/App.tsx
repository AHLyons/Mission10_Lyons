import React from 'react';
import logo from './logo.svg';
import './App.css';
import Table from './Table';

// import BowlingLeague from './BowlingLeague.sqlite';

function Welcome() {
  return <h1>Bowler Information</h1>;
}

function App() {
  return (
    <div className="App">
      <Welcome />
      <Table />
    </div>
  );
}

export default App;
