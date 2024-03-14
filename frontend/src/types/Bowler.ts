import { Team } from './Team';

export type Bowler = {
  bowlerID: number;
  bowlerFirstName: string;
  bowlerLastName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  team: Team;
};
