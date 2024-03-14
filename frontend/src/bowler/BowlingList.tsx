import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler'; // Ensure this import reflects wherever your types are defined

export function BowlingList() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  // Ensures the API is called when the component is loaded
  useEffect(() => {
    const fetchBowlers = async () => {
      const response = await fetch(
        'http://localhost:5063/api/Bowling/GetJoinedTables',
      );
      const data = await response.json();
      setBowlers(data);
    };
    fetchBowlers();
  }, []);

  return (
    <div className="row">
      <div className="text-center">
        <h4>Bowling Roster</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>PhoneNumber</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((bowler) => (
            <tr key={bowler.bowlerID}>
              <td>{bowler.bowlerFirstName}</td>
              <td>{bowler.bowlerMiddleInit}</td>
              <td>{bowler.bowlerLastName}</td>
              <td>{bowler.team.teamName}</td>
              <td>{bowler.bowlerAddress}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
