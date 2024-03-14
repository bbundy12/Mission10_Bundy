import logo from './Bowling.jpg';

export function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" height={350} />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">Bowling League Stats</h1>
        <p className="text-white">
          View the stats for the city bowling league. Today we are highlighting
          the sharks and the marlins
        </p>
      </div>
    </header>
  );
}
