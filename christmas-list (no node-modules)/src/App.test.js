import { render, screen } from '@testing-library/react';
import App from './App';

test('renders list element', () => {
  render(<App />);
  const listELem = screen.getByText(/christmas list/i);
  expect(listELem).toBeInTheDocument();
});
