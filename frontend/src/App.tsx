import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Header } from './Header';
import { BowlingList } from './bowler/BowlingList';

function App() {
  return (
    <div className="App">
      <Header />
      <BowlingList />
    </div>
  );
}

export default App;
